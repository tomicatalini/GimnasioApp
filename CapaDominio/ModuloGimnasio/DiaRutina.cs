using System.Collections.Generic;

namespace CapaDominio.ModuloGimnasio
{
    public class DiaRutina
    {
        /// <summary>
        /// Id de dia
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Numero de dia
        /// </summary>
        public int Dia { get; set; }
        //public string Nombre { get; set; }

        /// <summary>
        /// Id de la rutina asociada
        /// </summary>
        public virtual int RutinaId { get; set; }

        /// <summary>
        /// Rutina asociada
        /// </summary>
        public virtual Rutina Rutina { get; set; }
        
        /// <summary>
        /// Lista de lineas asociada al dia
        /// </summary>
        public virtual IList<LineaEjercicio> LineasEjercicio { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public DiaRutina() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="rutina"></param>       
        public DiaRutina(int dia, Rutina rutina)
        {
            this.Dia = dia;
            this.RutinaId = rutina.Id;
            this.Rutina = rutina;

            this.LineasEjercicio = new List<LineaEjercicio>();
        }
    }
}
