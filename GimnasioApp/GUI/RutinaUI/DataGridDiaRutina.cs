using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimnasioApp.GUI.RutinaUI
{
    public partial class DataGridDiaRutina : UserControl
    {
        public DataGridDiaRutina()
        {
            InitializeComponent();

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
    }
}
