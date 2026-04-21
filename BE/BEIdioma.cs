using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEIdioma
    {
        public int Id { get; set; }              // Identificador del idioma
        public string Nombre { get; set; }       // Ej: Español, Inglés
        public string Cultura { get; set; }      // Ej: "es-AR", "en-US"

    }
}