using System.Collections.Generic;
using CapaDominio.ModuloGimnasio;

namespace CapaDominio.ModuloGimnasio
{
    public class Musculo
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
