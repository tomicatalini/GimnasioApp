using System;
using CapaDominio.ModuloGimnasio;
using CapaBaseDatos;
using System.Collections.Generic;
using CapaBaseDatos.Repositorios;
using System.Linq;

namespace CapaNegocio.Controladores
{
    public class ControladorCuota
    {
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorCuota()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        /// <summary>
        /// Alta Cuota
        /// </summary>
        /// <param name="pFecEmision"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pMonto"></param>
        /// <param name="pMes"></param>
        /// <param name="pAño"></param>
        /// <param name="unSocio"></param>
        public void AltaCuota(DateTime pFecEmision, string pDescripcion, float pMonto, string pMes, int pAño, Socio unSocio)
        {
            var unaCuota = new Cuota(pFecEmision, pDescripcion, pMonto, pMes, pAño, unSocio);
            this.iUnitOfWork.CuotaRepository.Add(unaCuota);
        }

        /// <summary>
        /// Obtiene cuota por NroCuota.
        /// </summary>
        /// <param name="pNroCuota"></param>
        /// <returns></returns>
        public Cuota GetCuotaByNroCuota(int pNroCuota)
        {
            return iUnitOfWork.CuotaRepository.Get(pNroCuota);
        }

        public void BajaCuota(string pApellido, int pNroCuota)
        {
            var unSocio = this.iUnitOfWork.SocioRepository.GetSociosByString(pApellido);
  
        }

        /// <summary>
        /// Update de Cuotas
        /// </summary>
        /// <param name="pFecEmision"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pMonto"></param>
        /// <param name="pMes"></param>
        /// <param name="pAño"></param>
        /// <param name="pNroCuota"></param>
        public void ModificarCuota(DateTime pFecEmision, string pDescripcion, float pMonto, string pMes, int pAño, int pNroCuota)
        {
            //Se obtiene la referencia de la cuota que se quiere modificar
            var unaCuota = this.GetCuotaByNroCuota(pNroCuota);

            //Se realizan las modificiaciones
            unaCuota.FecEmision = pFecEmision;
            unaCuota.Descripcion = pDescripcion;
            unaCuota.Monto = pMonto;
            unaCuota.Mes = pMes;
            unaCuota.Año = pAño;
        }

        /// <summary>
        /// Persiste los cambios en la BD
        /// </summary>
        public void GuardarCambios()
        {
            this.iUnitOfWork.Complete();
        }

    }
}
