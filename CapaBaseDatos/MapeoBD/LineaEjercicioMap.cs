using System.Data.Entity.ModelConfiguration;
using CapaDominio.ModuloGimnasio;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaBaseDatos.MapeoBD
{
    class LineaEjercicioMap : EntityTypeConfiguration<LineaEjercicio>
    {
        public LineaEjercicioMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("LineaEjercicio");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(lineaEjercicio => lineaEjercicio.Id)
                .Property(LineaEjercicio => LineaEjercicio.Id)
                    .HasColumnName("lineaId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad linea: nombre y not null
            this.Property(lineaEjercicio => lineaEjercicio.Linea)
                    .HasColumnName("nombre")
                    .IsRequired();

            //conf. propiedad SerieRepeticion: nombre y not null
            this.Property(lineaEjercicio => lineaEjercicio.SerieRepeticion)
                    .HasColumnName("serieRepeticion")
                    .IsRequired();

            //conf. propiedad Descanso: nombre y not null
            this.Property(lineaEjercicio => lineaEjercicio.Descanso)
                    .HasColumnName("descanso")
                    .IsRequired();

            //conf. propiedad Observacion: nombre y not null
            //this.Property(lineaEjercicio => lineaEjercicio.Observacion)
            //        .HasColumnName("observacion")
            //        .IsRequired();
        }       
    }
}
