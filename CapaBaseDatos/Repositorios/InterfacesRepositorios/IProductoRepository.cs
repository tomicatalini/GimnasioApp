using System.Collections.Generic;
using CapaDominio.ModuloComercio;
using CapaBaseDatos.DTO;

namespace CapaBaseDatos.Repositorios.InterfacesRepositorios
{
    /// <summary>
    /// Repositorio generico para acceder a los productos
    /// </summary>
    public interface IProductoRepository : IRepository<Producto>
    {
        
        List<ProductoDTO> GetAllProductoDTO();
    }
}
