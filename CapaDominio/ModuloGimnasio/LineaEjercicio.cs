
namespace CapaDominio.ModuloGimnasio
{
    public class LineaEjercicio
    {
        /// <summary>
        /// Id de la linea
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Numero de linea
        /// </summary>
        public int Linea { get; set; }

        /// <summary>
        /// Id del musculo de la linea
        /// </summary>
        public virtual int MusculoId { get; set; }

        /// <summary>
        /// Musculo de la linea
        /// </summary>
        public virtual Musculo Musculo { get; set; }

        /// <summary>
        /// Id del ejercicio de la linea
        /// </summary>
        public virtual int EjercicioId { get; set; }

        /// <summary>
        /// Ejercicio de la linea
        /// </summary>
        public virtual Ejercicio Ejercicio { get; set; }

        /// <summary>
        /// Id del dia de la linea
        /// </summary>
        public virtual int DiaRutinaId { get; set; }

        /// <summary>
        /// Dia de la linea
        /// </summary>
        public virtual DiaRutina DiaRutina { get; set; }

        /// <summary>
        /// Numero repeticiones por serie de la linea
        /// </summary>
        public string SerieRepeticion { get; set; }

        /// <summary>
        /// Segundos de descanso de la linea
        /// </summary>
        public int Descanso { get; set; }

        //public string Observacion; //Para detallar pesos, o alguna especificacion.

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public LineaEjercicio() { }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="musculo"></param>
        /// <param name="ejercicio"></param>
        /// <param name="serieRepeticion"></param>
        /// <param name="descanso"></param>
        public LineaEjercicio(Musculo musculo, Ejercicio ejercicio, string serieRepeticion, int descanso)
        {
            this.EjercicioId = ejercicio.Id;
            this.Ejercicio = ejercicio;

            this.MusculoId = musculo.Id;
            this.Musculo = musculo;

            this.SerieRepeticion = serieRepeticion;
            this.Descanso = descanso;
        }
    }
}
