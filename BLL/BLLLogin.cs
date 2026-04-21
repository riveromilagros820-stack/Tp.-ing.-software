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
        private static readonly BLLLogin instancia = new BLLLogin();
        public static BLLLogin Instancia => instancia;

        private BLLLogin() { }

        public Usuario IniciarSesion(string dni, string contraseña)
        {
            Usuario usuario = new MPPUsuario().ObtenerPorDNI(dni);

            if (usuario != null && usuario.Activo)
            {
                if (usuario.Contraseña == contraseña)
                {
                    SessionManager.IniciarSesion(usuario);

                    // Instancia de MPPBitacora
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
