using System;
using System.Collections.Generic;
using CapaBaseDatos.Repositorios;
using CapaDominio.ModuloGimnasio;
using CapaBaseDatos;

namespace BusinessLayer.Controladores
{
    class ControladorOperacion
    {
        /// <summary>
        /// Contexto de la base de datos junto con el patron UnitOfWork
        /// </summary>
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorOperacion()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        /// <summary>
        /// Alta de Operación
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pNombre"></param>
        /// <param name="pFecOperacion"></param>
        /// <param name="pfecAltaMedica"></param>
        /// <param name="pFichaId"></param>
        public void AltaOperacion(int pId, string pNombre, DateTime pFecOperacion, DateTime pfecAltaMedica, int pFichaId)
        {
            var unaFichaMedica = this.iUnitOfWork.HistorialMedicoRepository.Get(pFichaId);
            var unaOperacion = new Operacion(pId, pNombre, pFecOperacion, pfecAltaMedica, unaFichaMedica);

            unaFichaMedica.Operaciones.Add(unaOperacion);
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