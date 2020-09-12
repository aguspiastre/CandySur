using CandySur.SEG.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Service
{
    public class SessionManager
    {
        static List<IIdiomaObserver> observers = new List<IIdiomaObserver>();
        private SessionManager() { }

        private static SessionManager session;
        public Entity.Usuario Usuario { get; set; }

        public Entity.Idioma Idioma { get; set; }

        public static SessionManager GetInstance()
        {
            if (session == null) return new SessionManager();

            return session;
        }

        public static void Login(Entity.Usuario usuario)
        {
            if (session == null)
            {
                session = new SessionManager();
                session.Usuario = usuario;
            }
        }

        public static void LogOut()
        {
            session = null;
        }
    }
}
