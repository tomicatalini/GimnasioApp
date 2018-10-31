using System;
using CapaBaseDatos;
using CapaDominio.ModuloGimnasio;

namespace CapaNegocio.Controladores
{
    class ControladorEnfermedad
    {
        /// <summary>
        /// Contexto de la base de datos junto con el patron UnitOfWork
        /// </summary>
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorEnfermedad()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        /// <summary>
        /// Alta de enfermedad
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pNombre"></param>
        /// <param name="pFichaId"></param>
        public void AltaEnfermedad(int pId, string pNombre, int pFichaId)
        {
            var unaFichaMedica = this.iUnitOfWork.HistorialMedicoRepository.Get(pFichaId);
            var unaEnfermedad = new Enfermedad(pId, pNombre, unaFichaMedica);

            unaFichaMedica.Enfermedades.Add(unaEnfermedad);
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
