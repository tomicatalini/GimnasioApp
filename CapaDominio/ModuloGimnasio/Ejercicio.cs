using System;
using System.Collections.Generic;

namespace CapaDominio.ModuloGimnasio
{
    public class Ejercicio
    {        
        /// <summary>
        /// Id del ejercicio
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del ejercicio
        /// </summary>
        public string Nombre { get; set; }

        //public virtual int MusculoId { get; set; }
        //public virtual Musculo Musculo { get; set; }

        /// <summary>
        /// Lista de lineas asociadas al ejercicio
        /// </summary>
        public virtual IList<LineaEjercicio> LineasEjercicio { get; set; }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Ejercicio(){ }
        
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="musculo"></param>
        public Ejercicio(string nombre, Musculo musculo)
        {
            this.Nombre = nombre;
            this.LineasEjercicio = new List<LineaEjercicio>();

            //this.MusculoId = musculo.Id;
            //this.Musculo = musculo;
        }
    }
}
