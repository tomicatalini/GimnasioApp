using System.Data.Entity;
using CapaDominio.ModuloComercio;
using CapaDominio.ModuloGimnasio;
using CapaBaseDatos.MapeoBD;

namespace CapaBaseDatos
{
    public class GimnasioBD : DbContext
    {

        //Contructor de la clase
        public GimnasioBD() : base()
        {
            //Crea la base de datos en caso de no existir
            Database.SetInitializer<GimnasioBD>(new CreateDatabaseIfNotExists<GimnasioBD>());

            //Elimina la base de datos si cambio el modelo. Luego la crea nuevamente, con los cambios correspondientes
            Database.SetInitializer<GimnasioBD>(new DropCreateDatabaseIfModelChanges<GimnasioBD>());
        }

        //Repositorios

        //Repositorio Socio
        public DbSet<Socio> Socios { get; set; }

        ////Repositorios Cuota
        public DbSet<Cuota> Cuotas { get; set; }
        //public DbSet<PagoDTO> Pagos { get; set; }

        ////Repositorios Rutina
        public DbSet<Rutina> Rutinas { get; set; }
        public DbSet<DiaRutina> DiasRutinas {get; set;}
        public DbSet<Musculo> Musculos { get; set; }
        public DbSet<Ejercicio> Ejercios { get; set; }
        public DbSet<LineaEjercicio> LineasEjercicio { get; set; }

        ///Repositorios Ficha Medica
        public DbSet<FichaMedica> FichasMedicas { get; set; }
        public DbSet<ActividadFisica> ActividadesFisicas { get; set; }
        public DbSet<ContactoEmergencia> ContactosEmergencia { get; set; }
        public DbSet<Enfermedad> Enfermedades {get; set;}
        public DbSet<LimitacionFisica> LimitacionesFisicas {get; set;}
        public DbSet<Medicacion> Medicamentos {get; set;}
        public DbSet<Operacion> Operaciones {get; set;}

        ////Repositorios Movimiento
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<LineaMovimiento> LineasMovimientos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TipoProducto> TiposProductos { get; set; }

        ////Repositorio Gasto Administrativo
        public DbSet<GastoAdministrativo> GastosAdministrativos { get; set; }

        //Configuracion de mapeo
        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            //Configuracion de un Socio, tanto en tabla como en relaciones
            pModelBuilder.Configurations.Add(new SocioMap());

            ////Modulo Cuota
            pModelBuilder.Configurations.Add(new CuotaMap());
            pModelBuilder.Configurations.Add(new PagoMap());

            ////Modulo Rutinas
            pModelBuilder.Configurations.Add(new RutinaMap());
            pModelBuilder.Configurations.Add(new DiaRutinaMap());
            pModelBuilder.Configurations.Add(new MusculoMap());
            pModelBuilder.Configurations.Add(new EjercicioMap());
            pModelBuilder.Configurations.Add(new LineaEjercicioMap());


            ////Modulo Ficha Medica
            pModelBuilder.Configurations.Add(new FichaMedicaMap());
            pModelBuilder.Configurations.Add(new ActividadFisicaMap());
            pModelBuilder.Configurations.Add(new ContactoEmergenciaMap());
            pModelBuilder.Configurations.Add(new EnfermedadMap());
            pModelBuilder.Configurations.Add(new LimitacionFisicaMap());
            pModelBuilder.Configurations.Add(new MedicacionMap());
            pModelBuilder.Configurations.Add(new OperacionMap());

            ////Modulo movimiento            
            pModelBuilder.Configurations.Add(new MovimientoMap());
            pModelBuilder.Configurations.Add(new LineaMovimientoMap());
            pModelBuilder.Configurations.Add(new ProductoMap());
            pModelBuilder.Configurations.Add(new TipoProductoMap());

            ////Gasto Administrativo
            pModelBuilder.Configurations.Add(new GastoAdministrativoMap());

            base.OnModelCreating(pModelBuilder);
        }
    }
}
