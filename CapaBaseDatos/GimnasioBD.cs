﻿using System.Data.Entity;
using CapaDominio.ModuloComercio;
using CapaDominio.ModuloGimnasio;

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
        //public DbSet<DetalleRutinaDTO> DetallesRutinas {get; set;}
        //public DbSet<MusculoDTO> Musculos { get; set; }
        //public DbSet<EjercicioDTO> Ejercios { get; set; }

        ////Repositorios Ficha Medica
        //public DbSet<FichaMedicaDTO> FichasMedicas { get; set; }
        //public DbSet<ActividadFisicaDTO> ActividadesFisicas { get; set; }
        //public DbSet<ContactoEmergenciaDTO> ContactosEmergencia { get; set; }
        //public DbSet<EnfermedadDTO> Enfermedades {get; set;}
        //public DbSet<LimitacionFisicaDTO> LimitacionesFisicas {get; set;}
        //public DbSet<MedicacionDTO> Medicamentos {get; set;}
        //public DbSet<OperacionDTO> Operaciones {get; set;}

        ////Repositorios Movimiento
        //public DbSet<MovimientoDTO> Movimientos { get; set; }
        //public DbSet<LineaMovimientoDTO> LineasMovimientos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TipoProducto> TiposProductos { get; set; }

        ////Repositorio Gasto Administrativo
        //public DbSet<GastoAdministrativoDTO> GastosAdministrativos { get; set; }

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
            pModelBuilder.Configurations.Add(new DetalleRutinaMap());
            pModelBuilder.Configurations.Add(new MusculoMap());
            pModelBuilder.Configurations.Add(new EjercicioMap());


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