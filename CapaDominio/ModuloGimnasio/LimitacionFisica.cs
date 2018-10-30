using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.ModuloGimnasio
{
    class LimitacionFisica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FecOcurrencia { get; set; }
        public DateTime FecRecuperacion { get; set; }

        public virtual int FichaId { get; set; }
        public virtual FichaMedica FichaMedica { get; set; }
    }
}
