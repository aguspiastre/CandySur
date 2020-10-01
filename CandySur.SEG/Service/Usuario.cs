using CandySur.SEG.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CandySur.SEG.Util;
using static CandySur.SEG.Util.Enums;

namespace CandySur.SEG.Service
{
    public class Usuario
    {
        private Repository.Usuario repository;
        private Service.DigitoVerificador dv;
        private Service.Familia familia;
        private Service.Patente patente;
        private Service.Bitacora bitacora;
        private Service.ControlCambios controlCambios;

        public Usuario()
        {
            repository = new Repository.Usuario();
            dv = new Service.DigitoVerificador();
            familia = new Service.Familia();
            patente = new Service.Patente();
            bitacora = new Service.Bitacora();
            controlCambios = new Service.ControlCambios();
        }

        public void AltaUsuario(Entity.Usuario usuario)
        {
            try
            {
                bool nombreValido = this.ValidarNombre(usuario.NombreUsuario);

                if (!nombreValido)
                    throw new Exception("El nombre de usuario ya se encuentra dado de alta.");

                string password = this.GenerarContraseña();

                //Encriptacion de nombre y contraseña
                usuario.Contraseña = Util.Encrypt.Encriptar(password, (int)TipoEncriptacion.Irreversible);
                usuario.NombreUsuario = Util.Encrypt.Encriptar(usuario.NombreUsuario, (int)TipoEncriptacion.Reversible);

                //Generacion DVH
                usuario.DVH = dv.CalcularDVH(this.ConcatenarRegistro(usuario));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.Alta(usuario);

                    dv.ActualizarDVV("Usuario");

                    int idUsuario = repository.ObtenerUltimoId();

                    //Control de Cambios
                    this.RegistrarControlCambios(usuario, idUsuario);

                    scope.Complete();
                }

                this.EnviarMailContraseña(password, usuario.Mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerarContraseña(string nombre, string mail)
        {
            try
            {
                Entity.Usuario usuario = this.Consultar(nombre);

                if (usuario == null)
                    throw new Exception("No se encontro al usuario.");

                if (!usuario.Mail.Equals(mail))
                    throw new Exception("El mail ingresado NO con corresponde con el usuario.");

                string password = this.GenerarContraseña();

                usuario.Contraseña = Util.Encrypt.Encriptar(password, (int)TipoEncriptacion.Irreversible);

                usuario.DVH = dv.CalcularDVH(this.ConcatenarRegistro(usuario));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.GenerarContraseña(usuario);

                    //Control de Cambios
                    this.RegistrarControlCambios(usuario, usuario.Id);

                    dv.ActualizarDVV("Usuario");

                    scope.Complete();
                }

                this.EnviarMailContraseña(password, mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CambiarContraseña(string nombre, string passwordVieja, string passwordNueva)
        {
            try
            {
                Entity.Usuario usuario = this.Consultar(nombre);

                if (!usuario.Contraseña.Equals(Util.Encrypt.Encriptar(passwordVieja, (int)TipoEncriptacion.Irreversible)))
                    throw new Exception("Contraseña incorrecta.");

                usuario.Contraseña = Util.Encrypt.Encriptar(passwordNueva, (int)TipoEncriptacion.Irreversible);

                usuario.DVH = dv.CalcularDVH(this.ConcatenarRegistro(usuario));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.GenerarContraseña(usuario);

                    //Control de Cambios
                    this.RegistrarControlCambios(usuario, usuario.Id);

                    dv.ActualizarDVV("Usuario");

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Entity.Usuario Consultar(string nombre)
        {
            Entity.Usuario usuario = repository.Consultar(Util.Encrypt.Encriptar(nombre, (int)TipoEncriptacion.Reversible));

            if (usuario == null)
                throw new Exception("No se encontro al usuario.");

            ObtenerPermisos(usuario);

            return usuario;
        }

        public int Eliminar(Entity.Usuario usuario)
        {
            try
            {
                //if (VerificarAdministrador(usuario))
                //    throw new Exception("El usuario contiene permisos de administrador, no puede ser eliminado.");

                if (!this.ValidarEliminacion(usuario))
                    throw new Exception("No se puede eliminar al usuario debido a que contiene patentes que no tienen otra asignacion.");

                usuario.NombreUsuario = Encrypt.Encriptar(usuario.NombreUsuario, (int)TipoEncriptacion.Reversible);
                usuario.Eliminado = true;
                usuario.DVH = dv.CalcularDVH(this.ConcatenarRegistro(usuario));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.Eliminar(usuario, usuario.DVH);

                    //Control de Cambios
                    this.RegistrarControlCambios(usuario, usuario.Id);

                    dv.ActualizarDVV("Usuario");

                    scope.Complete();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Modificar(Entity.Usuario usuario, bool esControlCambios)
        {
            try
            {
                usuario.NombreUsuario = Encrypt.Encriptar(usuario.NombreUsuario, (int)TipoEncriptacion.Reversible);
                usuario.DVH = dv.CalcularDVH(this.ConcatenarRegistro(usuario));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.Modificar(usuario, usuario.DVH, esControlCambios);

                    //Control de Cambios
                    this.RegistrarControlCambios(usuario, usuario.Id);

                    dv.ActualizarDVV("Usuario");

                    scope.Complete();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Entity.Usuario> Listar(int filtrarBloqueados = 0)
        {
            return repository.Listar(filtrarBloqueados);
        }

        private bool VerificarAdministrador(Entity.Usuario usuario)
        {
            if (usuario.Permisos != null)
                return usuario.Permisos.Any(p => p.Nombre == "Administrador");

            return false;
        }


        public bool ValidarNombre(string username)
        {
            if (repository.ValidarNombre(Util.Encrypt.Encriptar(username, (int)TipoEncriptacion.Reversible)) != 0)
                return false;

            return true;
        }

        public string GenerarContraseña()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[10];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        public void EnviarMailContraseña(string contraseña, string mail)
        {
            string body = @"Se genero una contraseña para su usuario. Podra cambiar la misma desde el login de la aplicación. Contraseña generada: " + contraseña;

            CandySur.UTIL.Mail.EnviarMail(mail, "Generacion de contraseña", body);
        }

        public int AumentarContador(Entity.Usuario usuario)
        {
            try
            {
                Entity.Usuario user = new Entity.Usuario
                {
                    Id = usuario.Id,
                    Apellido = usuario.Apellido,
                    Bloqueado = usuario.Bloqueado,
                    Nombre = usuario.Nombre,
                    NombreUsuario = Encrypt.Encriptar(usuario.NombreUsuario, (int)TipoEncriptacion.Reversible),
                    Contraseña = usuario.Contraseña,
                    Direccion = usuario.Direccion,
                    DNI = usuario.DNI,
                    Eliminado = usuario.Eliminado,
                    FechaNac = usuario.FechaNac,
                    Mail = usuario.Mail,
                    Telefono = usuario.Telefono,
                    Reintentos = usuario.Reintentos + 1
                };

                user.DVH = dv.CalcularDVH(this.ConcatenarRegistro(user));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int reintentos = repository.AumentarContador(user.Id, user.Reintentos, user.DVH);

                    //Control de Cambios
                    this.RegistrarControlCambios(user, user.Id);

                    dv.ActualizarDVV("Usuario");

                    scope.Complete();

                    return reintentos;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ReiniciarContador(Entity.Usuario usuario)
        {
            try
            {
                Entity.Usuario user = new Entity.Usuario
                {
                    Id = usuario.Id,
                    Apellido = usuario.Apellido,
                    Bloqueado = usuario.Bloqueado,
                    Nombre = usuario.Nombre,
                    NombreUsuario = Encrypt.Encriptar(usuario.NombreUsuario, (int)TipoEncriptacion.Reversible),
                    Contraseña = usuario.Contraseña,
                    Direccion = usuario.Direccion,
                    DNI = usuario.DNI,
                    Eliminado = usuario.Eliminado,
                    FechaNac = usuario.FechaNac,
                    Mail = usuario.Mail,
                    Telefono = usuario.Telefono,
                    Reintentos = 0,
                };

                user.DVH = dv.CalcularDVH(this.ConcatenarRegistro(user));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.ReiniciarContador(user.Id, user.DVH);

                    //Control de Cambios
                    this.RegistrarControlCambios(user, user.Id);

                    dv.ActualizarDVV("Usuario");

                    scope.Complete();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int BloquearUsuario(Entity.Usuario usuario)
        {
            try
            {
                Entity.Usuario user = new Entity.Usuario
                {
                    Id = usuario.Id,
                    Apellido = usuario.Apellido,
                    Reintentos = usuario.Reintentos,
                    Nombre = usuario.Nombre,
                    NombreUsuario = Encrypt.Encriptar(usuario.NombreUsuario, (int)TipoEncriptacion.Reversible),
                    Contraseña = usuario.Contraseña,
                    Direccion = usuario.Direccion,
                    DNI = usuario.DNI,
                    Eliminado = usuario.Eliminado,
                    FechaNac = usuario.FechaNac,
                    Mail = usuario.Mail,
                    Telefono = usuario.Telefono,
                    Bloqueado = true
                };

                user.DVH = dv.CalcularDVH(this.ConcatenarRegistro(user));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.BloquearUsuario(user.Id, user.DVH);

                    //Control de Cambios
                    this.RegistrarControlCambios(user, user.Id);

                    dv.ActualizarDVV("Usuario");

                    scope.Complete();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Desbloquear(Entity.Usuario usuario)
        {
            try
            {
                usuario.NombreUsuario = Encrypt.Encriptar(usuario.NombreUsuario, (int)TipoEncriptacion.Reversible);
                usuario.Bloqueado = false;
                usuario.Reintentos = 0;
                usuario.DVH = dv.CalcularDVH(this.ConcatenarRegistro(usuario));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.Desbloquear(usuario.Id, usuario.DVH);

                    //Control de Cambios
                    this.RegistrarControlCambios(usuario, usuario.Id);

                    dv.ActualizarDVV("Usuario");

                    scope.Complete();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Entity.Permiso> ObtenerPermisos(Entity.Usuario usuario)
        {
            try
            {
                List<Entity.Permiso> permisos = repository.ObtenerPermisos(usuario.Id);

                foreach (Entity.Permiso p in permisos)
                {
                    if (p.Compuesto)
                        usuario.Permisos.Add(familia.Consultar(p.Nombre));
                    else
                        usuario.Permisos.Add(patente.Consultar(p.Nombre));
                }

                return permisos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CompararContraseña(string contraseña, string contraseñaIngresada)
        {
            return contraseña == contraseñaIngresada;
        }

        public bool ValidarEstado(Entity.Usuario usuario)
        {
            return usuario.Bloqueado;
        }

        private bool ValidarEliminacion(Entity.Usuario usuario)
        {
            SEG.Service.Patente patenteService = new SEG.Service.Patente();

            foreach (Entity.Permiso permiso in usuario.Permisos)
            {
                if (permiso.Compuesto)
                {
                    SEG.Entity.Familia fam = familia.Consultar(permiso.Nombre);

                    foreach (SEG.Entity.Patente patente in fam.Permisos)
                    {
                        if (patenteService.ObtenerUsuariosAsignados(patente.Id, usuario.Id) == 0)
                            return false;
                    }
                }
                else
                {
                    if (patenteService.ObtenerUsuariosAsignados(permiso.Id, usuario.Id) == 0)
                        return false;
                }
            }

            return true;
        }

        private string ConcatenarRegistro(Entity.Usuario usuario)
        {
            return usuario.Nombre + usuario.Apellido + usuario.DNI + usuario.NombreUsuario + usuario.Contraseña + usuario.Direccion + usuario.Telefono + usuario.Reintentos
                + usuario.Mail + usuario.FechaNac.ToString() + usuario.Eliminado + usuario.Bloqueado;
        }

        private void RegistrarControlCambios(Entity.Usuario usuario, int idUsuario)
        {
            Entity.ControlCambios c = new Entity.ControlCambios
            {
                Id = idUsuario,
                Apellido = usuario.Apellido,
                Bloqueado = usuario.Bloqueado,
                Contraseña = usuario.Contraseña,
                Direccion = usuario.Direccion,
                DNI = usuario.DNI,
                Eliminado = usuario.Eliminado,
                FechaNac = usuario.FechaNac,
                Fecha_Modif = DateTime.Now,
                Id_Usuario = usuario.Id,
                Mail = usuario.Mail,
                Nombre = usuario.Nombre,
                NombreUsuario = usuario.NombreUsuario,
                Reintentos = usuario.Reintentos,
                Telefono = usuario.Telefono
            };

            controlCambios.Registrar(c);
        }

    }
}
