using CapaDominio.ModuloGimnasio;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;


namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad FichaMedica
    /// </summary>

    public class HistorialMedicoRepository : Repository<FichaMedica, GimnasioBD>, IHistorialMedicoRepository
    {

        public HistorialMedicoRepository(GimnasioBD pContext) : base(pContext) { }

        //public FichaMedica getFichaID(int pFichaID) { return ; }        
    }
}