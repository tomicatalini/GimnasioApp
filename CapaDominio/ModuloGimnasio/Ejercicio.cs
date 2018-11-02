using System.Collections.Generic;

namespace CapaDominio.ModuloGimnasio
{
    public class Ejercicio
    {

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual IList<LineaEjercicio> LineasEjercicio { get; set; }

        public Ejercicio(){ }
        
        public Ejercicio(string nombre)
        {
            this.Nombre = nombre;
            this.LineasEjercicio = new List<LineaEjercicio>();
        }
    }
}
