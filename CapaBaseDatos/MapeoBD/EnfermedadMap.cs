﻿using System.Data.Entity.ModelConfiguration;
using CapaDominio.ModuloGimnasio;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaBaseDatos.MapeoBD
{
    class EnfermedadMap : EntityTypeConfiguration<Enfermedad>
    {
        public EnfermedadMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("Enfermedad");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unaEnfermedad => unaEnfermedad.Id)
                .Property(unaEnfermedad => unaEnfermedad.Id)
                    .HasColumnName("enfermedadId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unaEnfermedad => unaEnfermedad.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

        }
    }
}
