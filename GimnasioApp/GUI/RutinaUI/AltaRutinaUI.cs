using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimnasioApp.GUI.RutinaUI
{
    public partial class AltaRutinaUI : Form
    {
        private int iCantidadDias = 0;

        public AltaRutinaUI()
        {
            InitializeComponent();
            AgregarDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarDataGrid();
        }

        public void AgregarDataGridDias()
        {

            
            //flowLayoutPanel1.Controls.Add(dataGrid);

            //this.tableLayoutPanel1.RowCount++;
            //int row = this.tableLayoutPanel1.RowCount;
            //this.tableLayoutPanel1.Controls.Add(new DataGridDiaRutina());
            //this.tableLayoutPanel1.SetRow(new DataGridDiaRutina(), row);
        }

        private void panelDias_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void AltaRutinaUI_Resize(object sender, EventArgs e)
        {
            //this.dataGridDiaRutina1.Width = Convert.ToInt32(this.flowLayoutPanel1.Width * 0.99) ;
            //this.dataGridDiaRutina1.Width = this.flowLayoutPanel1.Width - 15;
        }

        private void dataGridDia_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridDia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            var columna = dataGrid.Columns[e.ColumnIndex];

            if (columna.Name == "agregar")
            {
                if (e.RowIndex >= 0)
                {
                    dataGrid.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    dataGrid.Rows.Add();
                }
            }
        }

        private void dataGridDia_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Height += dataGrid.Rows[e.RowIndex].Height;
        }

        private void dataGridDia_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //var dataGrid = (DataGridView)sender;

            //if (dataGrid.Rows.Count > 1)
            //{
            //    dataGrid.Height -= dataGrid.Rows[e.RowIndex].Height;
            //}
        }

        public void AgregarDataGrid()
        {
            var nuevoDataGrid = new DataGridDiaRutina();
            this.iCantidadDias += 1;
            nuevoDataGrid.Width = this.panelContenedor.Width - (this.panelContenedor.Padding.Right * 2);
            nuevoDataGrid.Controls["lblTextoDia"].Text = "0"+this.iCantidadDias;
            this.panelContenedor.Controls.Add(nuevoDataGrid);
            nuevoDataGrid.Show();
        }
    }
}
