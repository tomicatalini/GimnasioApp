using CapaDominio.ModuloGimnasio;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;

namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad Cuota
    /// </summary>
    public class CuotaRepository : Repository<Cuota, GimnasioBD>, ICuotaRepository
    {
        public CuotaRepository(GimnasioBD pContext) : base(pContext) { }

    }
}
