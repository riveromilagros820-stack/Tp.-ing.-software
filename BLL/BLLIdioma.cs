using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLIdioma
    {
        private MPPIdioma mppIdioma = new MPPIdioma();
        private MPPBitacora bitacora = new MPPBitacora();

        public List<BEIdioma> ObtenerIdiomas()
        {
            return mppIdioma.ListarIdiomas();
        }

        public void CambiarIdioma(Usuario usuario, int nuevoIdiomaId)
        {
            mppIdioma.CambiarIdiomaUsuario(usuario.Id, nuevoIdiomaId);
            bitacora.Registrar(usuario.Id, "Idioma", $"Cambio de idioma a ID {nuevoIdiomaId}");
        }
    }
}
