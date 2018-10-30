using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using CapaDominio.ModuloComercio;
using CapaBaseDatos;
using CapaBaseDatos.DTO;

namespace CapaNegocio.Controladores
{
    public class ControladorProducto
    {

        UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControladorProducto()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        //
        //Get's
        //

        /// <summary>
        /// Obtiene un Producto especifico del repositorio.
        /// </summary>
        /// <param name="codigo"> codigo del producto</param>
        /// <returns>Producto</returns>
        public Producto GetProducto(int codigo)
        {
            return this.iUnitOfWork.ProductoRepository.Get(codigo);
        }

        /// <summary>
        /// Obtiene todos los productos del repositorio.
        /// </summary>
        /// <returns>lista de productos</returns>
        public List<Producto> GetAllProductos()
        {
            return this.iUnitOfWork.ProductoRepository.GetAll().ToList();
        }

        /// <summary>
        /// Obtiene un ProductoDTO especifico de la base de datos.
        /// El ProductoDTO es contiene informacion del producto como del tipo de producto.
        /// </summary>
        /// <param name="pId"></param>
        /// <returns> ProductoDTO </returns>
        public ProductoDTO GetProductoDTO(int codigo)
        {
            var lista = this.iUnitOfWork.ProductoRepository.GetAllProductoDTO();

            return lista.Find(unProd => unProd.CodProducto == codigo);
        }

        /// <summary>
        /// Obtiene todos los tipo de productos del repositorio.
        /// </summary>
        /// <returns> Lista de TipoProducto </returns>
        public List<TipoProducto> GetTipoProductos()
        {
            return this.iUnitOfWork.TipoProductoRepository.GetAll().ToList();
        }

        //
        //CUD (Create, Update and Delete)
        //

        /// <summary>
        /// Agrega un nuevo Producto al repositorio
        /// </summary>
        /// <param name="codProducto"></param>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="tipoProd"></param>
        /// <param name="contenido"></param>
        /// <param name="precio"></param>
        /// <param name="descripcion"></param>
        public void AltaProducto(int codProducto, string marca, string nombre, string tipoProd, float contenido, float precio, string descripcion)
        {
            //Busca el tipo de producto segun su "nombre"
            var listaTipos = GetTipoProductos();
            var tipoProducto = listaTipos.Find(unTipo => unTipo.Nombre.ToLower() == tipoProd);

            var unProd = new Producto(codProducto, marca, nombre, tipoProducto, contenido, precio, descripcion);
            this.iUnitOfWork.ProductoRepository.Add(unProd);
        }


        /// <summary>
        /// Modifica los datos de un Producto
        /// </summary>
        /// <param name="codProducto"></param>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="tipoProd"></param>
        /// <param name="contenido"></param>
        /// <param name="precio"></param>
        /// <param name="descripcion"></param>
        public void ModificarProducto(int codProducto, string marca, string nombre, string tipoProd, float contenido, float precio, string descripcion)
        {

            //Obtiene la referencia al objeto segun su codigo de producto
            var unProducto = this.iUnitOfWork.ProductoRepository.Get(codProducto);
            var tipoProducto = this.GetTipoProductos().Where(tipo => tipo.Nombre == tipoProd).First();

            //Se modifican sus datos
            unProducto.Marca = marca;
            unProducto.Nombre = nombre;
            unProducto.TipoProducto = tipoProducto;
            unProducto.Contenido = contenido;
            unProducto.Precio = precio;
            unProducto.Descripcion = descripcion;

        }
        
        /// <summary>
        /// Modifica el estado de un Producto, dejandolo "Inactivo"
        /// </summary>
        /// <param name="codProducto"></param>
        public void BajaProducto(int codProducto)
        {

            var unProducto = this.iUnitOfWork.ProductoRepository.Get(codProducto);
            unProducto.Activo = false;
        }


        //
        //Base de Datos (Unit of Work)
        //

        /// <summary>
        /// Realiza un commit a la base de datos.
        /// Sube a la BD los cambios realizados en los repositorios locales.
        /// </summary>
        public void GuardarCambios()
        {
            this.iUnitOfWork.Complete();
        }


        //
        //Operaciones Complementarias
        //
        
        /// <summary>
        /// Obtiene el codigo del siguiente Producto.
        /// Busca en la base de datos el codigo del ultimo producto agregado y devuelve el siguiente.
        /// </summary>
        /// <returns></returns>
        public int GetCodigoNuevoProducto()
        {
            var listaProductos = this.iUnitOfWork.ProductoRepository.GetAll().ToList();

            if (listaProductos.Any())
            {
                var ultProducto = listaProductos.Last();
                return (ultProducto.CodProducto + 1);
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Agrega un nuevo TipoProducto al repositorio local.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        public void AddTipoProducto(int id, string nombre)
        {
            this.iUnitOfWork.TipoProductoRepository.Add(new TipoProducto(id, nombre));
        }
        
        /// <summary>
        /// Modifica el precio de un Producto
        /// </summary>
        /// <param name="codProd"></param>
        /// <param name="precio"></param>
        public void ModificarPrecioProducto(int codProd, float precio)
        {
            var unProd = this.GetProducto(codProd);

            unProd.Precio = precio;
        }

        /// <summary>
        /// Modifica el precio de los productos en la lista.
        /// </summary>
        /// <param name="lista"></param>
        public void ModificarPrecioListaProductos(List<object> lista)
        {

            foreach (ProductoDTO item in lista)
            {

                this.ModificarPrecioProducto(item.CodProducto, item.Precio);
            }
        }

        /// <summary>
        /// Devuelve una lista con todos los Productos (DTO) que cumplan con los parametros ingresados.
        /// Filtra los productos.
        /// Se ingresa un "texto" y se buscan los productos que coincida dicho texto con alguno de los atributos
        /// "nombre", "marca" o "tipo" (UNION).
        /// </summary>
        /// <param name="texto"> "nombre", "marca" o "tipo" de un producto </param>
        /// <param name="filtro"> Si solo se quere obtener el conjunto de productos de un solo tipo (nombre o marca o tipo) </param>
        /// <returns></returns>
        public BindingList<ProductoDTO> ListarProductosFiltrados(string texto, string filtro)
        {

            var listaCompleta = this.iUnitOfWork.ProductoRepository.GetAllProductoDTO();
            var listaFiltrada = new List<ProductoDTO>();
            string txtVacio = texto;
            if (texto == "  Nombre, marca o tipo de producto")
                txtVacio = "";

            switch (filtro)
            {
                case "Nombre":
                    listaFiltrada = listaCompleta.Where(unProd => unProd.Nombre.StartsWith(txtVacio)).ToList();
                    break;
                case "Marca":
                    listaFiltrada = listaCompleta.Where(unProd => unProd.Marca.StartsWith(txtVacio)).ToList();
                    break;
                case "Tipo":
                    listaFiltrada = listaCompleta.Where(unProd => unProd.TipoProducto.StartsWith(txtVacio)).ToList();
                    break;
                default:
                    listaFiltrada = listaCompleta.Where(unProd => unProd.Nombre.StartsWith(txtVacio) || unProd.Marca.StartsWith(txtVacio) || unProd.TipoProducto.StartsWith(txtVacio)).ToList();
                    break;
            }

            return new BindingList<ProductoDTO>(listaFiltrada);
        }        

        /// <summary>
        /// Verifica si existe un "tipo" en el repositorio de TipoProducto
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public bool ExisteTipoProducto(string tipo)
        {

            var listaTipos = GetTipoProductos();
            bool resultado = listaTipos.Exists(tipos => tipos.Nombre == tipo);

            return resultado;
        }

        /// <summary>
        /// Obtiene una lista con todos los Productos (DTO) - Inner Join Producto y TipoProducto
        /// </summary>
        /// <returns></returns>
        public BindingList<ProductoDTO> GetProductoDTOs()
        {
            var lista = this.iUnitOfWork.ProductoRepository.GetAllProductoDTO();
            return new BindingList<ProductoDTO>(lista);
        }
    }
}
