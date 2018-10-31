using System;

namespace CapaDominio.ModuloGimnasio
{
    public class LimitacionFisica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FecOcurrencia { get; set; }
        public DateTime FecRecuperacion { get; set; }

        public virtual int FichaId { get; set; }
        public virtual FichaMedica FichaMedica { get; set; }

        public LimitacionFisica(int pId, string pNombre, DateTime pFecOcurrencia, DateTime pFecRecuperacion, FichaMedica pFichaMedica)
        {
            Id = pId;
            Nombre = pNombre;
            FecOcurrencia = pFecOcurrencia;
            FecRecuperacion = pFecOcurrencia;
            FichaId = pFichaMedica.FichaId;
        }
    }
}
