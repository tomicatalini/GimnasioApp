﻿using System;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaBaseDatos.Repositorios;

namespace CapaBaseDatos
{
    /// <summary>
    /// Implementacion del patron Unit of Work
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GimnasioBD iDbContext;

        public UnitOfWork(GimnasioBD pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }

            this.iDbContext = pContext;

            this.SocioRepository = new SocioRepository(this.iDbContext);
            this.CuotaRepository = new CuotaRepository(this.iDbContext);
            this.EjercicioRepository = new EjercicioRepository(this.iDbContext);
            this.MusculoRepository = new MusculoRepository(this.iDbContext);
            //this.PagoRepository = new PagoRepository(this.iDbContext);
            this.RutinaRepository = new RutinaRepository(this.iDbContext);
            this.MovimientoRepository = new MovimientoRepository(this.iDbContext);
            this.GastoAdministrativoRepository = new GastoAdministrativoRepository(this.iDbContext);
            this.ProductoRepository = new ProductoRepository(this.iDbContext);
            this.HistorialMedicoRepository = new HistorialMedicoRepository(this.iDbContext);
            this.TipoProductoRepository = new TipoProductoRepository(this.iDbContext);

        }

        public ISocioRepository SocioRepository
        {
            get; private set;
        }

        public ICuotaRepository CuotaRepository
        {
            get; private set;
        }

        public IRutinaRepository RutinaRepository { get; private set; }
        public IEjercicioRepository EjercicioRepository { get; private set; }
        public IMusculoRepository MusculoRepository { get; private set; }
        //public IPagoRepository PagoRepository
        //{
        //    get; private set;
        //}

        

        public IMovimientoRepository MovimientoRepository
        {
            get; private set;
        }

        public IGastoAdministrativoRepository GastoAdministrativoRepository
        {
            get; private set;
        }

        public IProductoRepository ProductoRepository
        {
            get; private set;
        }
        
        public ITipoProductoRepository TipoProductoRepository { get; private set; }

        public IHistorialMedicoRepository HistorialMedicoRepository
        {
            get; private set;
        }

        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.iDbContext.Dispose();
        }
    }
}
