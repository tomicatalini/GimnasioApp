﻿using System.Collections.Generic;
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

        public ControladorProducto()
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        public void AltaProducto(int codProducto, string marca, string nombre, string tipoProd, float contenido, float precio, string descripcion)
        {
            var listaTipos = GetTipoProductos();
            var tipoProducto = listaTipos.Find(unTipo => unTipo.Nombre.ToLower() == tipoProd);

            var unProd = new Producto(codProducto, marca, nombre, tipoProducto, contenido, precio, descripcion);
            this.iUnitOfWork.ProductoRepository.Add(unProd);
        }

        public IList<Producto> BuscarProductos(string cadena)
        {
            return this.iUnitOfWork.ProductoRepository.GetByCadena(cadena);
        }

        public void ModificarProducto(int codProducto, string marca, string nombre, string tipoProd, float contenido, float precio, string descripcion)
        {

            var unProducto = this.iUnitOfWork.ProductoRepository.Get(codProducto);
            var tipoProducto = this.iUnitOfWork.ProductoRepository.GetTiposProductos().Where(tipo => tipo.Nombre == tipoProd).First();

            unProducto.Marca = marca;
            unProducto.Nombre = nombre;
            unProducto.TipoProducto = tipoProducto;
            unProducto.Contenido = contenido;
            unProducto.Precio = precio;
            unProducto.Descripcion = descripcion;

        }

        public void BajaProducto(int codProducto)
        {

            var unProducto = this.iUnitOfWork.ProductoRepository.Get(codProducto);
            unProducto.Activo = false;
        }

        public int NumeroNuevoProducto()
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

        public void GuardarCambios()
        {
            this.iUnitOfWork.Complete();
        }

        public List<TipoProducto> GetTipoProductos()
        {
            return this.iUnitOfWork.TipoProductoRepository.GetAll().ToList();
        }

        public void AddTipoProducto(int id, string nombre)
        {
            this.iUnitOfWork.TipoProductoRepository.Add(new TipoProducto(id, nombre));
        }

        public List<Producto> GetProductos()
        {
            return this.iUnitOfWork.ProductoRepository.GetAll().ToList();
        }

        public ProductoDTO GetProductoDTO(int pId)
        {
            var lista = this.iUnitOfWork.ProductoRepository.ListaProductosInfoCompleta();
            return lista.Find(unProd => unProd.CodProducto == pId);
        }
        public Producto GetProducto(int codigo)
        {
            return this.iUnitOfWork.ProductoRepository.Get(codigo);
        }

        public void ModificarPrecioProducto(int codProd, float precio)
        {
            var unProd = this.GetProducto(codProd);

            unProd.Precio = precio;
        }

        public BindingList<ProductoDTO> ListarProductosFiltrados(string texto, string filtro)
        {
            var listaCompleta = this.iUnitOfWork.ProductoRepository.ListaProductosInfoCompleta();
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

        public void CambiarPreciosProductos(List<object> lista)
        {

            foreach (ProductoDTO item in lista)
            {

                this.ModificarPrecioProducto(item.CodProducto, item.Precio);
            }
        }

        public bool ExisteTipoProducto(string tipo)
        {

            var listaTipos = GetTipoProductos();
            bool resultado = listaTipos.Exists(tipos => tipos.Nombre == tipo);

            return resultado;
        }

        //Analizar Existencia

        public BindingList<ProductoDTO> ListarProductosInfoCompleta()
        {
            var lista = this.iUnitOfWork.ProductoRepository.ListaProductosInfoCompleta();
            return new BindingList<ProductoDTO>(lista);
        }
    }
}
