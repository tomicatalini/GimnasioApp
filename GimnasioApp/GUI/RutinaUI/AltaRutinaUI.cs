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
            //AgregarDataGridDias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarDataGridDias();
        }

        public void AgregarDataGridDias()
        {
            
            //get a reference to the previous existent 
            RowStyle temp = this.tableLayoutPanel1.RowStyles[this.tableLayoutPanel1.RowCount - 1];
            //increase panel rows count by one
            this.tableLayoutPanel1.RowCount++;
            //add a new RowStyle as a copy of the previous one
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add your three controls
            var dataGrid = new DataGridDiaRutina();
            dataGrid.Anchor = AnchorStyles.None;
            dataGrid.AutoSize = true;
            this.tableLayoutPanel1.Controls.Add(dataGrid , 0, this.tableLayoutPanel1.RowCount - 1);
            
            //panelDias.Controls.Add(dataGrid);

            //this.tableLayoutPanel1.RowCount++;
            //int row = this.tableLayoutPanel1.RowCount;
            //this.tableLayoutPanel1.Controls.Add(new DataGridDiaRutina());
            ////this.tableLayoutPanel1.SetRow(new DataGridDiaRutina(), row);
        }

        private void panelDias_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
