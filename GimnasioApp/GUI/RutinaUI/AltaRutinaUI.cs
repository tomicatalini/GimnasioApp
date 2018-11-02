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
        public AltaRutinaUI()
        {
            InitializeComponent();
            AgregarDataGridDias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarDataGridDias();
        }

        public void AgregarDataGridDias()
        {
            DataGridDiaRutina dataGrid = new DataGridDiaRutina();
            dataGrid.Width = panelDias.Width;
            panelDias.Controls.Add(dataGrid);
        }

        private void panelDias_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
