using System.Data.Entity.ModelConfiguration;
using CapaDominio.ModuloComercio;
using System.ComponentModel.DataAnnotations.Schema;


namespace CapaBaseDatos.MapeoBD
{
    class LineaGastoAdministrativoMap : EntityTypeConfiguration<LineaGastoAdministrativo>
    {
        public LineaGastoAdministrativoMap()
        {
            this.ToTable("LineaGastoAdministrativo");

            //conf. propiedad cantidad: nombre y not null
            this.Property(unGasto => unGasto.Cantidad)
                    .HasColumnName("cantidad")
                    .IsRequired();

        
            //conf. propiedad descripcion: nombre y not null
            this.Property(unGasto => unGasto.Descripcion)
                    .HasColumnName("descripcion")
                    .IsRequired();

        
            //conf. propiedad precioUnitario: nombre y not null
            this.Property(unGasto => unGasto.precioUnitario)
                    .HasColumnName("precioUnitario")
                    .IsRequired();
        }
    }
}
