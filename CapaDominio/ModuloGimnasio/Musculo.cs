using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.ModuloGimnasio
{
    class Musculo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual IList<Ejercicio> Ejercicios { get; set; }
        public virtual IList<DetalleRutina> DetallesDeRutina { get; set; }

        public Musculo(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
