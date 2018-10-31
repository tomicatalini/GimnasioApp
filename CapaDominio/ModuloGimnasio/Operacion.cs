using System;

namespace CapaDominio.ModuloGimnasio
{
    public class Operacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FecOperacion { get; set; }
        public DateTime FecAltaMedica { get; set; }

        public virtual int FichaId { get; set; }
        public virtual FichaMedica FichaMedica { get; set; }

        public Operacion(int pId, string pNombre, DateTime pFecOperacion, DateTime pFecAltaMedica, FichaMedica pFichaMedica)
        {
            Id = pId;
            Nombre = pNombre;
            FecOperacion = pFecOperacion;
            FecAltaMedica = pFecAltaMedica;
            FichaId = pFichaMedica.FichaId;
        }
    }
}