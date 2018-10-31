using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaBaseDatos.DTO;
using CapaNegocio.Controladores;

namespace GimnasioApp.GUI.ProductoUI
{
    public partial class AltaProductoUI : Form
    {
        bool iModificado;
        //El tipo de ventana hace referencia a que si va a ser de Alta o Modificar
        public AltaProductoUI(string tipoVentana)
        {
            InitializeComponent();
            this.iModificado = false;

            string texto = string.Format("{0} - Producto", tipoVentana);
            this.labelTitulo.Text = texto;
        }

        public AltaProductoUI(string tipoVentana, object unProducto)
        {
            InitializeComponent();
            this.iModificado = false;

            var unProd = (ProductoDTO)unProducto;
            string texto = string.Format("{0} - Producto", tipoVentana);
            this.labelTitulo.Text = texto;

            this.txtCodProducto.Text = unProd.CodProducto.ToString();
            this.rTxtDescripcion.Text = unProd.Descripcion;
            this.txtNombre.Text = unProd.Nombre;
            this.txtMarca.Text = unProd.Marca;
            this.cbxTipo.Text = unProd.TipoProducto;
            this.txtContenido.Text = unProd.Contenido.ToString();
            this.txtPrecio.Text = unProd.Precio.ToString();
        }

        private void OnLoadHandler(object sender, EventArgs e)
        {

            ControladorProducto adminProd = new ControladorProducto();
            AltaProductoUI ventanaPpal = (AltaProductoUI)sender;

            ventanaPpal.txtCodProducto.Text = adminProd.GetCodigoNuevoProducto().ToString();
            ventanaPpal.cbxTipo.DataSource = adminProd.GetTipoProductos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            AltaProductoUI ventanaPpal = (AltaProductoUI)btn.FindForm();
            var adminProd = new ControladorProducto();

            int codProducto = int.Parse(ventanaPpal.txtCodProducto.Text.Trim());
            string marca = ventanaPpal.txtMarca.Text.Trim().ToLower();
            string nombre = ventanaPpal.txtNombre.Text.Trim().ToLower();
            string tipoProducto = ventanaPpal.cbxTipo.Text.Trim().ToLower();
            float contenido = float.Parse(ventanaPpal.txtContenido.Text.Trim());
            float precio = float.Parse(ventanaPpal.txtPrecio.Text.Trim());
            string descripcion = ventanaPpal.rTxtDescripcion.Text.Trim();

            if (this.iModificado)
            {
                adminProd.ModificarProducto(codProducto, marca, nombre, tipoProducto, contenido, precio, descripcion);
            }
            else
            {
                adminProd.AltaProducto(codProducto, marca, nombre, tipoProducto, contenido, precio, descripcion);
            }

            adminProd.GuardarCambios();
        }

        private void CerrarVentana(object sender, EventArgs e)
        {
            //this.Owner.Show();
            this.Close();
        }

        private void AgregarSiNoExiste(object sender, EventArgs e)
        {
            //Inicializacion de variables
            var comboBox = (ComboBox)sender;
            var adminProd = new ControladorProducto();
            string nombre = comboBox.Text.Trim();
            string msj;
            DialogResult resultado;

            //Si el valor ingresado no es vacio
            if (!(string.IsNullOrEmpty(nombre)))
            {
                //Si el valor ingresado no existe en la base de datos
                if (!adminProd.ExisteTipoProducto(nombre))
                {
                    msj = string.Format(@"El Tipo de Producto: '{0}' no existe en la base de datos. Desea agregarlo?", nombre);
                    resultado = MessageBox.Show(msj, "Alta Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        //Agrega el nuevo Tipo de Producto al Repositorio
                        adminProd.AddTipoProducto(1, nombre);
                    }
                    else
                    {

                        comboBox.Text = "";
                        comboBox.Focus();
                    }

                }

                adminProd.GuardarCambios();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var formPrincipal = this.TopLevelControl;
            var buscarProductoUI = formPrincipal.Controls["panelContenedor"].Controls["BuscarProductoUI"];

            buscarProductoUI.Show();
            this.Close();
        }
    }
}
