using System;
using System.Collections.Generic;
using CapaNegocio;
using CapaBaseDatos;
using CapaDominio.ModuloGimnasio;

namespace CapaNegocio.Controladores
{
    class ControladorActividadFisica
    {
        /// <summary>
        /// Contexto de la base de datos junto con el patron UnitOfWork
        /// </summary>
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorActividadFisica()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        /// <summary>
        /// Alta de ActividadFisica
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pNombre"></param>
        /// <param name="pCantHoraSem"></param>
        /// <param name="pFichaId"></param>
        public void AltaActvidadFisica(int pId, string pNombre, int pCantHoraSem, int pFichaId)
        {
            var unaFichaMedica = this.iUnitOfWork.HistorialMedicoRepository.Get(pFichaId);
            var unaActividadFisica = new ActividadFisica(pId, pNombre, pCantHoraSem, unaFichaMedica);

            unaFichaMedica.ActividadesFisicas.Add(unaActividadFisica);
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
