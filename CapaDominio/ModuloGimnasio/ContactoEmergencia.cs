using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.ModuloGimnasio
{
    class ContactoEmergencia
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }
        public long Telefono { get; set; }

        //Relationship navigation
        public virtual int FichaId { get; set; }
        public virtual FichaMedica FichaMedica { get; set; }
    }
}
