using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Controladores;

namespace GimnasioApp.GUI
{
    public partial class PantallaCarga : Form
    {
        int iTiempo;

        public PantallaCarga()
        {
            InitializeComponent();
            this.iTiempo = 0;
            this.temporizador.Interval = 1000;
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {

            this.label3.Location = new Point(223 - this.iTiempo, 234);
            this.label3.Text += ".";

            if (iTiempo > 3)
            {
                this.label3.Location = new Point(223, 234);
                this.label3.Text = "El programa se abrira en unos segundos";
                this.iTiempo = 0;
            }

            this.iTiempo++;
        }

        private void PantallaCarga_Load(object sender, EventArgs e)
        {

            this.temporizador.Start();
            this.segundoPlano.RunWorkerAsync();
        }

        private void segundoPlano_DoWork(object sender, DoWorkEventArgs e)
        {

            ControladorProducto adminProd = new ControladorProducto();
            adminProd.GetAllProductos();
        }

        private void segundoPlano_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.temporizador.Stop();
            this.Close();
        }
    }
}
