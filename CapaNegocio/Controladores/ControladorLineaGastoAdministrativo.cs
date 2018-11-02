using System;
using CapaBaseDatos.Repositorios;
using CapaBaseDatos;
using CapaDominio.ModuloComercio;

namespace CapaNegocio.Controladores
{
    class ControladorLineaGastoAdministrativo
    {
        private UnitOfWork iUnitOfWork;

        public ControladorLineaGastoAdministrativo()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        public void AltaLineaGastoAdministrativo(int pId, int pCantidad, string pDescripcion, float pPrecioUnitario, int pIdGastoAdministrativo)
        {
            var unaGastoAdministrativo = this.iUnitOfWork.GastoAdministrativoRepository.Get(pIdGastoAdministrativo);
            var unaLineaGastoAdministrativo = new LineaGastoAdministrativo(pId, pCantidad, pDescripcion, pPrecioUnitario, pIdGastoAdministrativo);

            unaGastoAdministrativo.LineaGastosAdministrativos.Add(unaLineaGastoAdministrativo);
            this.iUnitOfWork.GastoAdministrativoRepository.Add(unaGastoAdministrativo);
        }

    }
}
