using System;
using CapaBaseDatos;
using CapaDominio.ModuloGimnasio;
using CapaNegocio.Controladores;

namespace CapaNegocio.Controladores
{
    class ControladorFichaMedica
    {
        /// <summary>
        /// Contexto de base de datos junto con el patron UnitOfWork
        /// </summary>
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorFichaMedica()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        /// <summary>
        /// Alta ficha Medica
        /// </summary>
        /// <param name="pFichaId"></param>
        /// <param name="pFechaEntrega"></param>
        /// <param name="pPeso"></param>
        /// <param name="pAltura"></param>
        /// <param name="pGrupoSanguineo"></param>
        /// <param name="pHiperArterial"></param>
        /// <param name="pDiabetes"></param>
        /// <param name="pAfecCardVascular"></param>
        /// <param name="pAfecResp"></param>
        /// <param name="pFuma"></param>
        /// <param name="pAlcohol"></param>
        /// <param name="pDniSocio"></param>
        /// <param name="pMedicacion"></param>
        /// <param name="pContactoEmergencia"></param>
        /// <param name="pEnfermedad"></param>
        /// <param name="pOperacion"></param>
        /// <param name="pLimitacionFisica"></param>
        /// <param name="pActividadFisica"></param>
        public void AltaFichaMedica(int pFichaId, DateTime pFechaEntrega, int pPeso, int pAltura, string pGrupoSanguineo, bool pHiperArterial, bool pDiabetes, bool pAfecCardVascular, bool pAfecResp, bool pFuma, bool pAlcohol, int pDniSocio, Medicacion pMedicacion, ContactoEmergencia pContactoEmergencia, Enfermedad pEnfermedad, Operacion pOperacion, LimitacionFisica pLimitacionFisica, ActividadFisica pActividadFisica)
        {
            var unSocio = this.iUnitOfWork.SocioRepository.Get(pDniSocio);
            var unaFichaMedica = new FichaMedica(pFichaId, DateTime.Today.Date, pPeso, pAltura, pGrupoSanguineo, pHiperArterial, pDiabetes, pAfecCardVascular, pAfecResp, pFuma, pAlcohol, pDniSocio, pMedicacion, pContactoEmergencia, pEnfermedad, pOperacion, pLimitacionFisica, pActividadFisica);


            unSocio.HistorialMedico.Add(unaFichaMedica);
            this.iUnitOfWork.SocioRepository.Add(unSocio);
        }

        /// <summary>
        /// Obtiene ficha medica por ID
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public FichaMedica getFichaByID(int pId)
        {
            return iUnitOfWork.HistorialMedicoRepository.Get(pId);
        }

        /// <summary>
        /// Update ficha Medica
        /// </summary>
        /// <param name="pFichaId"></param>
        /// <param name="pFechaEntrega"></param>
        /// <param name="pPeso"></param>
        /// <param name="pAltura"></param>
        /// <param name="pGrupoSanguineo"></param>
        /// <param name="pHiperArterial"></param>
        /// <param name="pDiabetes"></param>
        /// <param name="pAfecCardVascular"></param>
        /// <param name="pAfecResp"></param>
        /// <param name="pFuma"></param>
        /// <param name="pAlcohol"></param>
        /// <param name="pDniSocio"></param>
        /// <param name="pMedicacion"></param>
        /// <param name="pContactoEmergencia"></param>
        /// <param name="pEnfermedad"></param>
        /// <param name="pOperacion"></param>
        /// <param name="pLimitacionFisica"></param>
        /// <param name="pActividadFisica"></param>
        public void ModificarFichaMedica(int pFichaId, DateTime pFechaEntrega, int pPeso, int pAltura, string pGrupoSanguineo, bool pHiperArterial, bool pDiabetes, bool pAfecCardVascular, bool pAfecResp, bool pFuma, bool pAlcohol, int pDniSocio, Medicacion pMedicacion, ContactoEmergencia pContactoEmergencia, Enfermedad pEnfermedad, Operacion pOperacion, LimitacionFisica pLimitacionFisica, ActividadFisica pActividadFisica)
        {
            //Se obtiene la referencia del socio que se quiere modificar su fichaMedica
            var unaFichaMedica = this.getFichaByID(pFichaId);

            //Se realizan las modificaciones
            unaFichaMedica.FechaEntrega = pFechaEntrega;
            unaFichaMedica.Peso = pPeso;
            unaFichaMedica.Altura = pAltura;
            unaFichaMedica.GrupoSanguineo = pGrupoSanguineo;
            unaFichaMedica.HiperArterial = pHiperArterial;
            unaFichaMedica.Diabetes = pDiabetes;
            unaFichaMedica.AfecCardVascular = pAfecCardVascular;
            unaFichaMedica.AfecResp = pAfecResp;
            unaFichaMedica.Fuma = pFuma;
            unaFichaMedica.Alcohol = pAlcohol;
            unaFichaMedica.SocioDNI = pDniSocio;
            unaFichaMedica.enfermedad = pEnfermedad;
            unaFichaMedica.contactoEmegencia = pContactoEmergencia;
            unaFichaMedica.operacion = pOperacion;
            unaFichaMedica.medicacion = pMedicacion;
            unaFichaMedica.limitacionFisica = pLimitacionFisica;
            unaFichaMedica.actividadFisica = pActividadFisica;
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