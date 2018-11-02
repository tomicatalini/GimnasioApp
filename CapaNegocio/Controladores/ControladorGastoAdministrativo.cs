using System;
using CapaBaseDatos;
using CapaDominio.ModuloComercio;

namespace CapaNegocio.Controladores
{
    class ControladorGastoAdministrativo
    {
        private UnitOfWork iUnitOfWork;

        public ControladorGastoAdministrativo()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        public void AltaGastoAdministrativo(int pId, DateTime pFecha)
        {
            var unGastoAdministrativo = new GastoAdministrativo(pId, pFecha);

            this.iUnitOfWork.GastoAdministrativoRepository.Add(unGastoAdministrativo);
            
        }
    }
}
