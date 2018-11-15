using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBaseDatos.Repositorios
{
    class LineaEjercicio
    {
        public IList<LineaEjercicio> GetLineaById(int id)
        {
            return this.iDbContext.LineasEjercicio.Where(unaLineaEjercicio => unaLineaEjercicio.Id == id);
        }
    }
}
