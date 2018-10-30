using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad Rutina
    /// </summary>
    public class RutinaRepository : Repository<Rutina, GimnasioBD>, IRutinaRepository
    {
        public RutinaRepository(GimnasioBD pContext) : base(pContext)
        {

        }
    }
}
