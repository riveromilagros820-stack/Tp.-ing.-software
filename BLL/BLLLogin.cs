using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using MPP;


namespace BLL
{
    public sealed class BLLLogin
    {
        private static BLLLogin instancia;
        private MPPUsuario usuarioMPP = new MPPUsuario();

        // Constructor privado
        private BLLLogin() { }

        // Propiedad estática para acceder a la instancia única
        public static BLLLogin Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new BLLLogin();
                }
                return instancia;
            }
        }

        public Usuario ValidarLogin(string apellido, int dni, string contraseña)
        {
            Usuario u = usuarioMPP.ObtenerPorDNI(dni);
            if (u == null) return null;

            string usuarioEsperado = apellido + dni;
            string usuarioReal = u.Apellido + u.DNI;

            if (usuarioEsperado == usuarioReal && u.Contraseña == contraseña)
            {
                return u;
            }
            return null;
        }

        public Usuario IniciarSesion(int dni, string contraseña)
        {
            Usuario usuario = new MPPUsuario().ObtenerPorDNI(dni);

            if (usuario != null && usuario.Activo)
            {
                if (usuario.Contraseña == contraseña)
                {
                    SessionManager.IniciarSesion(usuario);

                    MPPBitacora bitacora = new MPPBitacora();
                    bitacora.Registrar(usuario.Id, "Login", "Inicio de sesión exitoso");

                    return usuario;
                }
                else
                {
                    MPPBitacora bitacora = new MPPBitacora();
                    bitacora.Registrar(usuario.Id, "Login", "Contraseña incorrecta");
                }
            }
            else
            {
                MPPBitacora bitacora = new MPPBitacora();
                bitacora.Registrar(0, "Login", $"Intento fallido con DNI: {dni}");
            }

            return null;
        }



    }
}
  
