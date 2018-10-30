using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GimnasioApp.GUI.ProductoUI;

namespace GimnasioApp
{
    public partial class ProbandoFormularioPrincipal : Form
    {
        string botonActivo;
        Form iFormularioActivo;

        public ProbandoFormularioPrincipal()
        {

            InitializeComponent();
            this.btnInicio.Focus();
            botonActivo = "btnInicio";


        }

        private void btnInicio_click(object sender, EventArgs e)
        {
            DarFormatoBoton_Click(sender);

            //var inicioUI = new InicioUI();
            //inicioUI.TopLevel = false;
            //inicioUI.Dock = DockStyle.Fill;
            //this.panelContenedor.Controls.Add(inicioUI);
            //this.panelContenedor.Tag = inicioUI;
            //inicioUI.Show(this);
        }

        private void btnProducto_click(object sender, EventArgs e)
        {
            DarFormatoBoton_Click(sender);
            var buscarProductoUI = new InventarioProductoUI(false);
            this.iFormularioActivo = buscarProductoUI;

            buscarProductoUI.TopLevel = false;
            buscarProductoUI.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(buscarProductoUI);
            this.panelContenedor.Tag = buscarProductoUI;
            buscarProductoUI.Show();
        }

        private void DarFormatoBoton_Click(object sender)
        {
            var btn = (Button)sender;

            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(255, 60, 51);
            btn.ImageKey = string.Format("{0}2.png", btn.Name.Remove(0, 3).ToLower());
        }

        private void FormatoBotonInterno_Hover(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            btn.BackgroundImage = Image.FromFile(@"C:\Users\tomi_\Desktop\Poryecto Habilitacion\Iconos\probando.png");
        }

        private void FormatoBotonInterno_Leave(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            btn.BackgroundImage = null;
        }

        private void LimpiarFormatoBoton_Leave(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.ImageKey = string.Format("{0}.png", btn.Name.Remove(0, 3).ToLower());
        }

        private void ActivarBotonMenu_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            DarFormatoBoton_Click(btn);

            if (this.botonActivo == btn.Name)
            {
                AcomodarPanel("otro");
            }
            else
            {
                AcomodarPanel(btn.Name);
            }
        }

        private void AcomodarPanel(string botonName)
        {

            switch (botonName)
            {
                case "btnSocio":
                    this.panelSocio.Height = 258;
                    this.panelProductos.Height = 50;
                    this.panelRutina.Height = 50;
                    this.panelGestion.Height = 50;
                    this.botonActivo = botonName;
                    break;
                case "btnProducto":
                    this.panelProductos.Height = 118;
                    this.panelSocio.Height = 50;
                    this.panelRutina.Height = 50;
                    this.panelGestion.Height = 50;
                    this.botonActivo = botonName;
                    break;
                case "btnGestion":
                    this.panelGestion.Height = 50;
                    this.panelProductos.Height = 50;
                    this.panelRutina.Height = 50;
                    this.panelSocio.Height = 50;
                    this.botonActivo = botonName;
                    break;
                case "btnRutina":
                    this.panelRutina.Height = 50;
                    this.panelGestion.Height = 50;
                    this.panelProductos.Height = 50;
                    this.panelSocio.Height = 50;
                    this.botonActivo = botonName;
                    break;

                default:
                    this.panelGestion.Height = 50;
                    this.panelProductos.Height = 50;
                    this.panelSocio.Height = 50;
                    this.panelRutina.Height = 50;

                    this.botonActivo = "btnInicio";
                    this.btnInicio.Focus();
                    DarFormatoBoton_Click(btnInicio);
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprarProd_Click(object sender, EventArgs e)
        {
            if (!(this.iFormularioActivo is CompraVentaProductoUI))
            {
                this.iFormularioActivo.Close();
                this.iFormularioActivo = new CompraVentaProductoUI("Reposición");
            }

            DarFormatoBoton_Click(sender);
            this.iFormularioActivo.TopLevel = false;
            this.iFormularioActivo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(this.iFormularioActivo);
            this.panelContenedor.Tag = this.iFormularioActivo;
            this.iFormularioActivo.Show();
        }
    }
}
