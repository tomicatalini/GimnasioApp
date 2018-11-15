using System;
using System.Collections.Generic;

namespace CapaDominio.ModuloGimnasio
{
    public class Rutina
    {
        /// <summary>
        /// Id de la rutina
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la rutina
        /// </summary>
        public string Nombre { get; set; }
        
        /// <summary>
        /// Cantidad de dias de la rutina
        /// </summary>
        public int CantDias { get; set; }

        /// <summary>
        /// Fecha de inicio de la rutina
        /// </summary>
        public DateTime FecInicio { get; set; }

        /// <summary>
        /// Socios que realizan la rutina
        /// </summary>
        public virtual IList<Socio> Socios { get; set; }

        /// <summary>
        /// Dias de la rutina
        /// </summary>
        public virtual IList<DiaRutina> DiasRutina { get; set; }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Rutina() { }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="duracion"></param>
        /// <param name="fechaInicio"></param>
        public Rutina(string nombre, int duracion, DateTime fechaIncio)
        {
            this.Id = 1;
            this.CantDias = duracion;
            this.FecInicio = fechaIncio;
            this.Nombre = nombre;

            this.Socios = new List<Socio>();
            this.DiasRutina = new List<DiaRutina>();
        }
    }
}
