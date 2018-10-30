
namespace CapaDominio.ModuloGimnasio
{
    public class Medicacion
    {

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual int FichaId { get; set; }
        public virtual FichaMedica FichaMedica { get; set; }
    }
}
