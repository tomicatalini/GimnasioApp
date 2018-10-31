using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio.Controladores;

namespace GimnasioApp.GUI.ProductoUI
{
    public partial class InventarioProductoUI : Form
    {
        bool iVentaCompra = false;

        public InventarioProductoUI(bool EsVentaCompra)
        {
            InitializeComponent();
            this.iVentaCompra = EsVentaCompra;

            if (EsVentaCompra)
            {
                this.btnEdit.Visible = false;
                this.btnDelete.Visible = false;
            }
        }

        //
        //Handler's relacionados con el filtro de datos del data grid view listadoProductos
        //

        /// <summary>
        /// Manejador del evento Enter (obtener el foco) de TextBox/ComboBox.
        /// Vacia el contenido del text box y le cambia el formato.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProdBuscado_Enter(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;

            //txt.Text = "";
            txt.Font = new Font("Century Gothic", 8.75F, System.Drawing.FontStyle.Regular);
            txt.ForeColor = Color.Black;
        }

        private void comboBoxFiltrar_Enter(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;

            combo.Text = "";
            combo.Font = new Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular);
            combo.ForeColor = Color.Black;
        }

        private void comoBoxFiltrar_Leave(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;

            if (string.IsNullOrEmpty(combo.Text))
            {
                combo.Text = "  Buscar solo por";
                combo.Font = new Font("Century Gothic", 8.75F, System.Drawing.FontStyle.Italic);
                combo.ForeColor = Color.Gray;
            }

        }

        private void txtProdBuscado_Leave(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;

            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = "  Nombre, marca o tipo de producto";
                txt.Font = new Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic);
                txt.ForeColor = Color.Gray;
                this.comoBoxFiltrar.Enabled = false;
                this.comoBoxFiltrar.Text = "  Buscar solo por";
            }
        }

        private void BuscarProductoEnLista_KeyUp(object sender, KeyEventArgs e)
        {
            var txt = (TextBox)sender;
            var dataGrid = this.dataGridProductos;
            var comboBox = this.comoBoxFiltrar;
            var adminProd = new ControladorProducto();

            this.comoBoxFiltrar.Enabled = true;

            FiltroLista(comboBox.Text, txt.Text);

        }

        private void FiltroLista(string comboText, string txtText)
        {
            var comboBox = this.comoBoxFiltrar;
            var txt = this.txtProdBuscado;
            var dataGrid = this.dataGridProductos;
            var adminProd = new ControladorProducto();

            if (comoBoxFiltrar.Text == "  Buscar solo por")
                comboText = "Todo";

            dataGridProductos.DataSource = adminProd.ListarProductosFiltrados(txtText, comboText);
        }

        private void comoBoxFiltrar_TextChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var txt = this.txtProdBuscado;

            FiltroLista(comboBox.Text, txt.Text);
        }

        //
        //Handler's relacionados con la seleccion del producto en el dataGridView
        //
        private void SeleccionarProd(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && this.iVentaCompra)
            {
                var dataGrid = (DataGridView)sender;
                var adminProd = new ControladorProducto();

                int codigo = (int)dataGrid.CurrentRow.Cells["codProducto"].Value;
                var unProd = adminProd.GetProductoDTO(codigo);
                var compraVentaProductoUI = (CompraVentaProductoUI)this.Owner.Controls["panelContenedor"].Controls["CompraVentaProductoUI"];

                compraVentaProductoUI.AgregarProducto(unProd);
                this.Close();
            }
        }

        //private void SeleccionarProd(object sender, EventArgs e)
        //{
        //    var btn = (Button)sender;
        //    var VnaPpal = (BuscarProductoUI)btn.FindForm();

        //    var row = VnaPpal.dataGridProductos.CurrentRow;
        //    int codigo = (int)row.Cells["codProducto"].Value;
        //    owner.buscarProd(codigo);

        //    this.Close();
        //}

        private void CerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDataGrid(object sender, EventArgs e)
        {
            var adminProd = new ControladorProducto();
            var VnaPpal = (InventarioProductoUI)sender;

            VnaPpal.dataGridProductos.DataSource = adminProd.GetProductoDTOs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var btn = (Button)sender;
            var altaProductoUI = new AltaProductoUI("Alta");
            
            altaProductoUI.Dock = DockStyle.Fill;
            altaProductoUI.TopLevel = false;
            this.panelCU.Controls.Add(altaProductoUI);
            this.panelCU.Location = new Point(this.Width - 398, 0);
            this.panelCU.Width = 408;
            altaProductoUI.Show();
            this.panelCU.Visible = true;
            
            //var formPrincipal = this.TopLevelControl;


            //formPrincipal.Controls["panelContenedor"].Controls.Add(altaProductoUI);
            //formPrincipal.Controls["panelContenedor"].Tag = altaProductoUI;
            //altaProductoUI.Show();

            //this.Hide();
        }

        private void dataGridProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var adminProd = new ControladorProducto();
            var codigo = (int)dataGridProductos.CurrentRow.Cells["codProducto"].Value;
            var unProd = adminProd.GetProductoDTOs().Single(prod => prod.CodProducto == codigo);

            var altaProductoUI = new AltaProductoUI("Modificar", unProd);
            var formPrincipal = this.TopLevelControl;

            altaProductoUI.Height = this.Height;
            altaProductoUI.Width = this.Width;
            altaProductoUI.TopLevel = false;
            altaProductoUI.Dock = DockStyle.Fill;
            formPrincipal.Controls["panelContenedor"].Controls.Add(altaProductoUI);
            formPrincipal.Controls["panelContenedor"].Tag = altaProductoUI;
            altaProductoUI.Show();

            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var btn = (Button)sender;
            var adminProd = new ControladorProducto();
            DialogResult resultado;
            string msj = "Esta seguro que desea dar de baja el producto seleccionado?";

            var filaSeleccionada = dataGridProductos.CurrentRow;

            resultado = MessageBox.Show(msj, "Alta Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int codigo = (int)filaSeleccionada.Cells["codProducto"].Value;
                adminProd.BajaProducto(codigo);
                this.dataGridProductos.Rows.RemoveAt(filaSeleccionada.Index);
                adminProd.GuardarCambios();
            }

        }
    }
}
