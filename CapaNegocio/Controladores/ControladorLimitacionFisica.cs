using System;
using CapaBaseDatos;
using CapaDominio.ModuloGimnasio;

namespace CapaNegocio.Controladores
{
    class ControladorLimitacionFisica
    {
        /// <summary>
        /// Contexto de la base de datos junto con el patron UnitOfWork
        /// </summary>
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorLimitacionFisica()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        /// <summary>
        /// Alta de Limitacion Fisica
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pNombre"></param>
        /// <param name="pFecOcurrencia"></param>
        /// <param name="pFecRecuperacion"></param>
        /// <param name="pFichaId"></param>
        public void AltaLimitacionFisica(int pId, string pNombre, DateTime pFecOcurrencia, DateTime pFecRecuperacion, int pFichaId)
        {
            var unaFichaMedica = this.iUnitOfWork.HistorialMedicoRepository.Get(pFichaId);
            var unaLimitiacionFisica = new LimitacionFisica(1, pNombre, pFecOcurrencia, pFecRecuperacion, unaFichaMedica);

            unaFichaMedica.LimitacionesFisicas.Add(unaLimitiacionFisica);
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
