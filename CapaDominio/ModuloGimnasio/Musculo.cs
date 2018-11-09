﻿using System.Collections.Generic;
using CapaDominio.ModuloGimnasio;

namespace CapaDominio.ModuloGimnasio
{
    public class Musculo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual IList<LineaEjercicio> LineasEjercicio { get; set; }
        //public virtual IList<Ejercicio> Ejercicios { get; set; }
        
        public Musculo() { }

        public Musculo(string nombre)
        {
            this.Nombre = nombre;
            this.LineasEjercicio = new List<LineaEjercicio>();
            //this.Ejercicios = new List<Ejercicio>();
        }
    }
}
