using System.Collections.Generic;
using CapaDominio.ModuloGimnasio;

namespace CapaDominio.ModuloGimnasio
{
    public class Musculo
    {
        /// <summary>
        /// Id de musculo
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del musculo
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Lista de lineas asociadas al musculo
        /// </summary>
        public virtual IList<LineaEjercicio> LineasEjercicio { get; set; }
        //public virtual IList<Ejercicio> Ejercicios { get; set; }
        
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Musculo() { }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        public Musculo(string nombre)
        {
            this.Nombre = nombre;
            this.LineasEjercicio = new List<LineaEjercicio>();
            //this.Ejercicios = new List<Ejercicio>();
        }
    }
}
