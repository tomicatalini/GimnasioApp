﻿using System.Data.Entity.ModelConfiguration;
using CapaDominio.ModuloGimnasio;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaBaseDatos.MapeoBD
{
    class ActividadFisicaMap : EntityTypeConfiguration<ActividadFisica>
    {
        public ActividadFisicaMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("ActividadFisica");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unaActividad => unaActividad.Id)
                .Property(unaActividad => unaActividad.Id)
                    .HasColumnName("actividadId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unaActividad => unaActividad.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //conf. propiedad cantidad de horas semanales: nombre y not null
            this.Property(unaActividad => unaActividad.CantHoraSem)
                    .HasColumnName("horasSemanales")
                    .IsRequired();

        }
    }
}
