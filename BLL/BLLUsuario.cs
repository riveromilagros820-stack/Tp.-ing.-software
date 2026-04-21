using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario
    {
        private MPPUsuario mppUsuario = new MPPUsuario();

        public bool CrearUsuario(Usuario usuario)
        {
            try
            {
                mppUsuario.CrearUsuario(usuario);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CambiarContraseña(int usuarioId, string nuevaContraseña)
        {
            try
            {
                
                mppUsuario.CambiarContraseña(usuarioId, nuevaContraseña);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    }
