using CapaBaseDatos;
using CapaDominio.ModuloGimnasio;

namespace CapaNegocio.Controladores
{
    class ControladorMedicacion
    {
        /// <summary>
        /// Contexto de la base de datos junto con el patron UnitOfWork
        /// </summary>
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorMedicacion()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        /// <summary>
        /// Alta medicacion
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pNombre"></param>
        /// <param name="pFichaId"></param>
        public void AltaMedicacion(int pId, string pNombre, int pFichaId)
        {
            var unaFichaMedica = this.iUnitOfWork.HistorialMedicoRepository.Get(pFichaId);
            var unaMedicacion = new Medicacion(pId, pNombre, unaFichaMedica);

            unaFichaMedica.Medicaciones.Add(unaMedicacion);
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

