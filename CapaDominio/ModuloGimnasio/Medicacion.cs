namespace CapaDominio.ModuloGimnasio
{
    public class Medicacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual int FichaId { get; set; }
        public virtual FichaMedica FichaMedica { get; set; }

        public Medicacion(int pId, string pNombre, FichaMedica pFichaMedica)
        {
            Id = pId;
            Nombre = pNombre;
            FichaId = pFichaMedica.FichaId;
        }
    }
}