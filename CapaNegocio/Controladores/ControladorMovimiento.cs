using System;
using CapaBaseDatos;
using CapaDominio.ModuloGimnasio;
using CapaDominio.ModuloComercio;

namespace CapaNegocio.Controladores
{
    class ControladorMovimiento
    {
        private UnitOfWork iUnitOfWork;

        public ControladorMovimiento()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        public void AltaMovimiento(int pId, DateTime pFecha, TipoMovimiento pTipoMovimiento)
        {
            var unMovimiento = new Movimiento(pId, pFecha, pTipoMovimiento);
            this.iUnitOfWork.MovimientoRepository.Add(unMovimiento);
        }
    }
}
