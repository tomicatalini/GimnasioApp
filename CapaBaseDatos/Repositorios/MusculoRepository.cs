using CapaDominio.ModuloGimnasio;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;

namespace CapaBaseDatos.Repositorios
{
    public class MusculoRepository : Repository<Musculo, GimnasioBD>, IMusculoRepository
    {
        public MusculoRepository(GimnasioBD pContext) : base(pContext) { }
    }
}
