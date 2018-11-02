using System.Collections.Generic;
using CapaDominio.ModuloGimnasio;

namespace CapaDominio.ModuloGimnasio
{
    public class Musculo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual IList<Ejercicio> Ejercicios { get; set; }
        
        public Musculo() { }

        public Musculo(string nombre)
        {
            this.Nombre = nombre;
            this.Ejercicios = new List<Ejercicio>();
        }
    }
}
