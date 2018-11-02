using System.Data.Entity.ModelConfiguration;
using CapaDominio.ModuloComercio;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaBaseDatos.MapeoBD
{
    class GastoAdministrativoMap : EntityTypeConfiguration<GastoAdministrativo>
    {
        public GastoAdministrativoMap()
        {
            //nombre de la table en base de datos
            this.ToTable("GastoAdministrativo");

            //conf. de clave primaria: nombre, auto-increment y not null
            this.HasKey(unGasto => unGasto.Id)
                .Property(unGasto => unGasto.Id)
                    .HasColumnName("gastoId")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            //conf. propiedad fecha: nombre y not null
            this.Property(unGasto => unGasto.Fecha)
                    .HasColumnName("fecha")
                    .IsRequired();
        }
    }
}
