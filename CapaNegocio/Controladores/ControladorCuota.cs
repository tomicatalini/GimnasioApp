using System;
using CapaDominio.ModuloGimnasio;
using CapaBaseDatos;


namespace CapaNegocio.Controladores
{
    public class ControladorCuota
    {
        private UnitOfWork iUnitOfWork;

        public ControladorCuota()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        public void AltaCuota(DateTime pFecEmision, string pDescripcion, float pMonto, string pMes, int pAño, Socio unSocio)
        {
            var unaCuota = new Cuota(pFecEmision, pDescripcion, pMonto, pMes, pAño, unSocio);
            this.iUnitOfWork.CuotaRepository.Add(unaCuota);
        }

    }
}
