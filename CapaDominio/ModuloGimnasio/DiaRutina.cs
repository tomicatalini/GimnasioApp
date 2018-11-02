using System.Collections.Generic;

namespace CapaDominio.ModuloGimnasio
{
    public class DiaRutina
    {

        public int Id { get; set; }
        public int Dia { get; set; }
        
        public virtual int RutinaId { get; set; }
        public virtual Rutina Rutina { get; set; }

        /*public virtual int MusculoId { get; set; }
        public virtual Musculo Musculo { get; set; }

        public virtual int EjercicioId { get; set; }
        public virtual Ejercicio Ejercicio { get; set; }*/

        public virtual IList<LineaEjercicio> LineasEjercicio { get; set; }


        public DiaRutina() { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="serieRepeticiones"></param>
        /// <param name="descanso"></param>
        /// <param name="rutina"></param>
        /// <param name="musculo"></param>
        public DiaRutina(int dia, Rutina rutina)
        {
            this.Dia = dia;
            this.RutinaId = rutina.Id;
            this.Rutina = rutina;

            this.LineasEjercicio = new List<LineaEjercicio>();
        }
    }
}
