using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimnasioApp.GUI.ProductoUI
{
    public partial class CompraVentaProductoUI : Form
    {
        string iTipoVentana;
        BindingList<Object> iListaProductos;

        public CompraVentaProductoUI(string tipo)
        {
            InitializeComponent();
            this.iListaProductos = new BindingList<object>();
            this.iTipoVentana = tipo;
            this.lblTitulo.Text = string.Format(@"{0} - Productos", tipo);
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            var buscarProductoUI = new InventarioProductoUI(true);
            this.TopLevel = false;
            //buscarProductoUI.Parent = this;
            var panelContenedor = this.TopLevelControl.Controls["panelContenedor"];
            buscarProductoUI.StartPosition = FormStartPosition.Manual;
            buscarProductoUI.Location = new Point(panelContenedor.Location.X, panelContenedor.Location.Y);
            buscarProductoUI.Dock = DockStyle.Fill;
            buscarProductoUI.Show(this);
        }

        public void AgregarProducto(object producto)
        {
            this.iListaProductos.Add(producto);
            this.dataGridProductos.DataSource = this.iListaProductos;
        }

        private void dataGridProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var dataGrid = (DataGridView)sender;

            dataGrid.CurrentCell = dataGrid.Rows[e.RowIndex].Cells["cantidad"];
            dataGrid.BeginEdit(true);
        }

        private void dataGridProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            var filaActual = dataGrid.Rows[e.RowIndex];
            float precio = (float)filaActual.Cells["precio"].Value;
            int cantidad = int.Parse(filaActual.Cells["cantidad"].Value.ToString().Trim());
            filaActual.Cells["subtotal"].Value = precio * cantidad;
        }
    }
}
