using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.ModuloGimnasio
{
    public class FichaMedica
    {
        //Properties navigation
        public int FichaId { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public string GrupoSanguineo { get; set; }
        public bool HiperArterial { get; set; }
        public bool Diabetes { get; set; }
        public bool AfecCardVascular { get; set; }
        public bool AfecResp { get; set; }
        public bool Fuma { get; set; }
        public bool Alcohol { get; set; }

        public ContactoEmergencia contactoEmegencia { get; set; }
        public Enfermedad enfermedad { get; set; }
        public Operacion operacion { get; set; }
        public LimitacionFisica limitacionFisica { get; set; }
        public ActividadFisica actividadFisica { get; set; }
        public Medicacion medicacion { get; set; }

        //Relationship Navigation
        public virtual int SocioDNI { get; set; }
        public virtual Socio Socio { get; set; }

        public virtual IList<ContactoEmergencia> ContactoEmergencia { get; set; }
        public virtual IList<Medicacion> Medicaciones { get; set; }
        public virtual IList<Enfermedad> Enfermedades { get; set; }
        public virtual IList<ActividadFisica> ActividadesFisicas { get; set; }
        public virtual IList<Operacion> Operaciones { get; set; }
        public virtual IList<LimitacionFisica> LimitacionesFisicas { get; set; }

        public FichaMedica(int pFichaId, DateTime pFechaEntrega, int pPeso, int pAltura, string pGrupoSanguineo, bool pHiperArterial, bool pDiabetes, bool pAfecCardVascular, bool pAfecResp, bool pFuma, bool pAlcohol, int pDniSocio, Medicacion pMedicacion, ContactoEmergencia pContactoEmergencia, Enfermedad pEnfermedad, Operacion pOperacion, LimitacionFisica pLimitacionFisica, ActividadFisica pActividadFisica)
        {
            FichaId = 1;
            FechaEntrega = pFechaEntrega;
            Peso = pPeso;
            Altura = pAltura;
            GrupoSanguineo = pGrupoSanguineo;
            HiperArterial = pHiperArterial;
            Diabetes = pDiabetes;
            AfecCardVascular = pAfecCardVascular;
            AfecResp = pAfecResp;
            Fuma = Fuma;
            Alcohol = pAlcohol;
            contactoEmegencia = pContactoEmergencia;
            enfermedad = pEnfermedad;
            operacion = pOperacion;
            limitacionFisica = pLimitacionFisica;
            actividadFisica = pActividadFisica;
            medicacion = pMedicacion;

            SocioDNI = pDniSocio;

            this.ContactoEmergencia = new List<ContactoEmergencia>();
            this.Enfermedades = new List<Enfermedad>();
            this.Operaciones = new List<Operacion>();
            this.Medicaciones = new List<Medicacion>();
            this.LimitacionesFisicas = new List<LimitacionFisica>();
            this.ActividadesFisicas = new List<ActividadFisica>();
        }
    }
}