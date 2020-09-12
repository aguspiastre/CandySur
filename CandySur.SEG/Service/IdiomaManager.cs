using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Service
{
    public class IdiomaManager
    {
        static List<IIdiomaObserver> observers = new List<IIdiomaObserver>();
        private IdiomaManager() { }

        private static IdiomaManager idiomaManager;

        public Entity.Idioma Idioma { get; set; }

        public static IdiomaManager GetInstance()
        {
            if (idiomaManager == null)
            {
                idiomaManager = new IdiomaManager();
            }

            return idiomaManager;
        }

        //Manejo multi-idiomas.
        public static void Suscribir(IIdiomaObserver o)
        {
            observers.Add(o);
        }
        public static void Desuscribir(IIdiomaObserver o)
        {
            observers.Remove(o);
        }

        private static void Notificar(Entity.Idioma idioma)
        {
            foreach (var o in observers)
            {
                o.ActualizarIdioma(idioma);
            }
        }
        public static void CambiarIdioma(Entity.Idioma idioma)
        {
            if (idiomaManager != null)
            {
                idiomaManager.Idioma = idioma;
                Notificar(idioma);
            }
        }
    }
}
