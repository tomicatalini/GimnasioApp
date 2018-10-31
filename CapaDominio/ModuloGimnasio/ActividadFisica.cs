using CapaDominio.ModuloGimnasio;

namespace CapaDominio.ModuloGimnasio
{
    public class ActividadFisica
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public int CantHoraSem { get; set; }

        public virtual int FichaId { get; set; }
        public virtual FichaMedica FichaMedica { get; set; }

        public ActividadFisica(int pId, string pNombre, int pCantHoraSem, FichaMedica pFichaMedica)
        {
            Id = pId;
            Nombre = pNombre;
            CantHoraSem = pCantHoraSem;
            FichaId = pFichaMedica.FichaId;
        }

    }
}
