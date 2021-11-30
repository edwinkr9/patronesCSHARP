using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Singleton
{
    public class Manager
    {

        private static Manager _session;
        public Usuario Usuario { get; set; }
        public DateTime FechaLogin { get; set; }
        public static Manager GetInstance
        {
            get
            {
                if (_session == null) throw new Exception("Sesión no iniciada");
                return _session;
            }
        }
        public static void Login(Usuario usuario)
        {
            if (_session == null)
            {
                _session = new Manager();
                _session.Usuario = usuario;
                _session.FechaLogin = DateTime.Now;
            }
            else
            {
                throw new Exception("Sesión iniciada");
            }
        }
        public static void Logout()
        {
            if (_session != null)
            {
                _session = null;
            }
            else
            {
                throw new Exception("Sesión no iniciada");
            }
        }
        private Manager()
        {

        }
    }
}
