using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Controladores;

namespace GimnasioApp.GUI.RutinaUI
{
    public partial class DataGridDiaRutina : UserControl
    {
        
        public DataGridDiaRutina()
        {
            InitializeComponent();
            dataGridDia.Rows.Add();
            DataGridDiaRutina_Load(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridDia.Rows.Add();
        }

        private void dataGridDia_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var row = dataGridDia.Rows[e.RowIndex];
            dataGridDia.Height += row.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var controlUsuario = (DataGridDiaRutina)btn.Parent;
            var dataGrid = (DataGridView)controlUsuario.Controls["dataGridDia"];
            var rowAElim = dataGrid.CurrentRow.Index;

            dataGrid.Height -= dataGrid.CurrentRow.Height;
            dataGrid.Rows.RemoveAt(rowAElim);
        }

        private void DataGridDiaRutina_Load(object sender)
        {
            var controlUsuario = (DataGridDiaRutina)sender;
            var comboBoxMusculo = (DataGridViewComboBoxColumn)controlUsuario.dataGridDia.Columns["musculo"];
            var comboBoxEjecicio = (DataGridViewComboBoxColumn)controlUsuario.dataGridDia.Columns["ejercicio"];
            var adminRutina = new ControladorRutina();

            comboBoxMusculo.DataSource = adminRutina.GetMusulos();
            comboBoxMusculo.DisplayMember = "nombre";

            comboBoxEjecicio.DataSource = adminRutina.GetEjercicios();
            comboBoxEjecicio.DisplayMember = "nombre";

        }
    }
}
