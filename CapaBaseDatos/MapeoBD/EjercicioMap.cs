using System.Data.Entity.ModelConfiguration;
using CapaDominio.ModuloGimnasio;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaBaseDatos.MapeoBD
{
    class EjercicioMap : EntityTypeConfiguration<Ejercicio>
    {
        public EjercicioMap()
        {
            //nombre de la tabla en base de datos
            this.ToTable("Ejercicio");

            //conf. clave primaria: nombre, auto-increment y not null
            this.HasKey(unEjercicio => unEjercicio.Id)
                .Property(unEjercicio => unEjercicio.Id)
                    .HasColumnName("ejercicioId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad nombre: nombre y not null
            this.Property(unEjercicio => unEjercicio.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired();

            //Relacion de agregacion entre Ejercicio y LineaEjercicio
            this.HasMany(unEjercicio => unEjercicio.LineasEjercicio)
                .WithRequired(lineaEjercicio => lineaEjercicio.Ejercicio)
                    .HasForeignKey(LineaEjercicio => LineaEjercicio.EjercicioId);
        }
    }
}
