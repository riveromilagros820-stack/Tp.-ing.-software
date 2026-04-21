using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class SessionManager
    {
        public static Usuario UsuarioActual { get; private set; }

        public static void IniciarSesion(Usuario usuario)
        {
            UsuarioActual = usuario;
        }

        public static void CerrarSesion()
        {
            if (UsuarioActual != null)
            {
                MPPBitacora bitacora = new MPPBitacora();
                bitacora.Registrar(UsuarioActual.Id, "Logout", "Cierre de sesión");
            }
            UsuarioActual = null;
        }

        public static bool SesionActiva()
        {
            return UsuarioActual != null;
        }
        
    }
}
