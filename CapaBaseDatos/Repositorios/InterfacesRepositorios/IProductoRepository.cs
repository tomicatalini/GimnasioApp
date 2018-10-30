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
        //Agregar metodos de productos.
        IList<Producto> GetByCadena(string cadena);
        IList<TipoProducto> GetTiposProductos();
        List<ProductoDTO> ListaProductosInfoCompleta();
    }
}
