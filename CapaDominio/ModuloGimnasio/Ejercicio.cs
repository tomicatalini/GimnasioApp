using System.Collections.Generic;

namespace CapaDominio.ModuloGimnasio
{
    public class Ejercicio
    {

        public int Id { get; set; }
        public string Nombre { get; set; }

        //public virtual int MusculoId { get; set; }
        //public virtual Musculo Musculo { get; set; }

        public virtual IList<LineaEjercicio> LineasEjercicio { get; set; }

        public Ejercicio(){ }
        
        public Ejercicio(string nombre, Musculo musculo)
        {
            this.Nombre = nombre;
            this.LineasEjercicio = new List<LineaEjercicio>();

            //this.MusculoId = musculo.Id;
            //this.Musculo = musculo;
        }
    }
}
