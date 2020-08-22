using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Entity
{
    public class SessionManager
    {
        private SessionManager() { }

        private static SessionManager session;
        public Usuario Usuario { get; set; }

        public static SessionManager GetInstance()
        {
            if (session == null) return new SessionManager();

            return session;
        }

        public static void Login(Usuario usuario)
        {
            if (session == null)
            {
                session = new SessionManager();
                session.Usuario = usuario;
            }
        }
    }
}
