using System;
using CapaBaseDatos.Repositorios;
using CapaBaseDatos;
using CapaDominio.ModuloComercio;

namespace CapaNegocio.Controladores
{
    class ControladorLineaMovimiento
    {
        private UnitOfWork iUnitOfWork;

        public ControladorLineaMovimiento()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        public void AltaLineaMovimiento(int pId, int pCantidad, float pPrecioUnitario, int pIdLineaMovimiento, Producto pProducto, int pIdMovimiento)
        {
            var unMovimiento = this.iUnitOfWork.MovimientoRepository.Get(pIdMovimiento);
            var unaLineaMovimiento = new LineaMovimiento(pId, pCantidad, pPrecioUnitario, pIdLineaMovimiento, pProducto);

            unMovimiento.LineaMovimientos.Add(unaLineaMovimiento);
            this.iUnitOfWork.MovimientoRepository.Add(unMovimiento);
        }
    }
}
