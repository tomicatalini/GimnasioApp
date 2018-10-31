using System;
using System.Collections.Generic;
using CapaNegocio;
using CapaBaseDatos;
using CapaDominio.ModuloGimnasio;

namespace BusinessLayer.Controladores
{
    class ControladorContactoEmergencia
    {
        /// <summary>
        /// Contexto de la base de datos junto con el patron UnitOfWork
        /// </summary>
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorContactoEmergencia()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        /// <summary>
        /// Alta ContactoEmergencia
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pNombre"></param>
        /// <param name="pTelefono"></param>
        /// <param name="pFichaId"></param>
        public void AltaContactoEmergencia(int pId, string pNombre, long pTelefono, int pFichaId)
        {
            var unaFichaMedica = this.iUnitOfWork.HistorialMedicoRepository.Get(pFichaId);
            var unContactoEmergencia = new ContactoEmergencia(pId, pNombre, pTelefono, unaFichaMedica);

            unaFichaMedica.ContactoEmergencia.Add(unContactoEmergencia);
        }

        /// <summary>
        /// Persiste los cambios en la BD
        /// </summary>
        public void GuardarCambios()
        {
            iUnitOfWork.Complete();
        }
    }
}
