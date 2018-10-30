using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaDominio.ModuloComercio;

namespace CapaBaseDatos.Repositorios
{
    public class TipoProductoRepository : Repository<TipoProducto, GimnasioBD>, ITipoProductoRepository
    {
        public TipoProductoRepository(GimnasioBD pContext) : base(pContext) { }
    }
}
