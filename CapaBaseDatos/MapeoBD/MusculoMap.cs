using System.Data.Entity.ModelConfiguration;
using CapaDominio.ModuloGimnasio;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaBaseDatos.MapeoBD
{
    class MusculoMap : EntityTypeConfiguration<Musculo>
    {
        public MusculoMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("Musculo");

            //conf. clave primaria: nombre, autoincrement y not null
            this.HasKey(unMusculo => unMusculo.Id)
                .Property(unMusculo => unMusculo.Id)
                    .HasColumnName("musculoId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unMusculo => unMusculo.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //Relacion de agregacion entre Ejercicio y LineaEjercicio
            this.HasMany(unMusculo => unMusculo.LineasEjercicio)
                .WithRequired(lineaEjercicio => lineaEjercicio.Musculo)
                    .HasForeignKey(LineaEjercicio => LineaEjercicio.MusculoId);

        }
    }
}
