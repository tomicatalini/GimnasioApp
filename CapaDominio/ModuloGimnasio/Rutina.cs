using System;
using System.Collections.Generic;

namespace CapaDominio.ModuloGimnasio
{
    public class Rutina
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantDias { get; set; }
        public DateTime FecInicio { get; set; }

        public virtual IList<Socio> Socios { get; set; }
        public virtual IList<DiaRutina> DiasRutina { get; set; }

        public Rutina() { }

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
