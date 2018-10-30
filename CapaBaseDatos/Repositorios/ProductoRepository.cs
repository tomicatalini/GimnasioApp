using System.Collections.Generic;
using System.Linq;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaDominio.ModuloComercio;
using CapaBaseDatos.DTO;

namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad Producto
    /// </summary>
    public class ProductoRepository : Repository<Producto, GimnasioBD>, IProductoRepository
    {
        public ProductoRepository(GimnasioBD pContext) : base(pContext){ }

        /// <summary>
        /// Devuelve una lista de productos, con infomacion completa ( Con el tipo de producto )
        /// </summary>
        /// <returns></returns>
        public List<ProductoDTO> GetAllProductoDTO()
        {
            string sql = "select * from dbo.ProdyTip p";
            string parametros = "CodProdcuto = p.codProducto, Nombre = p.nombre, Marca = p.marca, Contenido = p.Contenido, Precio = p.Precio, Descripcion = p.descripcion, Stock = p.stock, TipoProducto = p.tipoProducto ";
            var query = this.iDbContext.Database.SqlQuery<ProductoDTO>(sql, parametros).ToList();

            return query;
        }

    }
}
