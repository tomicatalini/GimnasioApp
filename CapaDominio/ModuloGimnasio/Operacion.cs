using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.ModuloGimnasio
{
    class Operacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FecOperacion { get; set; }
        public DateTime FecAltaMedica { get; set; }

        public virtual int FichaId { get; set; }
        public virtual FichaMedica FichaMedica { get; set; }
    }
}
