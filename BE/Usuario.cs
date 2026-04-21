using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string NombreUsuario { get; set; }
        public  string Apellido { get; set; }
        public string Contraseña { get; set; }
        public int DNI { get; set; }
        public  int IdiomaId { get; set; }
        public bool Activo { get; set; }
        public BEPerfil Perfil { get; set; }

        public Usuario()
        {
            // Instanciamos el perfil para que siempre esté disponible
            Perfil = new BEPerfil();
        }
    }


}
