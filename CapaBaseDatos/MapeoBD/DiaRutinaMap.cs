using System.Data.Entity.ModelConfiguration;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.MapeoBD
{
    class DiaRutinaMap : EntityTypeConfiguration<DiaRutina>
    {
        public DiaRutinaMap()
        {
            //Nombre de tabla en base de datos
            this.ToTable("DetalleRutina");

            //conf. clave primaria: nombre, autoincrement y not null
            this.HasKey(DiaRutina => DiaRutina.Id)
                .Property(unDetalle => unDetalle.Id)
                    .HasColumnName("detalleId")
                    .IsRequired();

            //conf. propiedad dia: nombre y not null
            this.Property(unDetalle => unDetalle.Dia)
                    .HasColumnName("dia")
                    .IsRequired();

            //Relacion de agregacion entre DiaRutina y LineaEjercicio
            this.HasMany(DiaRutina => DiaRutina.LineasEjercicio)
                .WithRequired(LineaEjercicio => LineaEjercicio.DiaRutina) //cambiar
                    .HasForeignKey(LineaEjercicio => LineaEjercicio.DiaRutinaId);
        }
    }
}
