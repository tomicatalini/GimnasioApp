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
        Button iBotonActivo;
        Form iFormularioActivo;

        public ProbandoFormularioPrincipal()
        {

            InitializeComponent();
            this.btnInicio.Focus();
            botonActivo = "btnInicio";
            this.iBotonActivo = this.btnInicio;


        }

        private void btnInicio_click(object sender, EventArgs e)
        {
           
            
            //var inicioUI = new InicioUI();
            //inicioUI.TopLevel = false;
            //inicioUI.Dock = DockStyle.Fill;
            //this.panelContenedor.Controls.Add(inicioUI);
            //this.panelContenedor.Tag = inicioUI;
            //inicioUI.Show(this);
        }

        public void AbrirFormularioHijo(object formulario)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            var formHijo = (Form)formulario;
            formHijo.TopLevel = false;
            formHijo.TopMost = true;
            formHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnProducto_click(object sender, EventArgs e)
        {
            
            var buscarProductoUI = new InventarioProductoUI(false);
            this.iFormularioActivo = buscarProductoUI;

            buscarProductoUI.TopLevel = false;
            buscarProductoUI.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(buscarProductoUI);
            this.panelContenedor.Tag = buscarProductoUI;
            buscarProductoUI.Show();
        }

        private void DarFormatoBoton_Click(Button button)
        {
            button.ForeColor = Color.White;
            button.BackColor = Color.FromArgb(255, 60, 51);
            //button.ImageKey = string.Format("{0}2.png", button.Name.Remove(0, 3).ToLower());
        }

        private void LimpiarFormatoBoton_Leave(Button button)
        {

            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
            //button.ImageKey = string.Format("{0}.png", button.Name.Remove(0, 3).ToLower());
        }

        private void ActivarBotonMenu_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;            
            DimensionarPanel_ButtonClick(btn);
            AbrirFormularioHijo(new InventarioProductoUI(true));
        }

        private void DimensionarPanel_ButtonClick(Button button)
        {
            var panelBoton = (FlowLayoutPanel)button.Parent;
            var panelBotonActivo = (FlowLayoutPanel)this.iBotonActivo.Parent;

            if (panelBoton.Name != panelBotonActivo.Name)
            {
                LimpiarFormatoBoton_Leave(this.iBotonActivo);
                DarFormatoBoton_Click(button);
                panelBoton.AutoSize = true;
                panelBotonActivo.AutoSize = false;
                panelBotonActivo.Size = new Size(220, 50);
                
                this.iBotonActivo = button;
            }

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

            
            this.iFormularioActivo.TopLevel = false;
            this.iFormularioActivo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(this.iFormularioActivo);
            this.panelContenedor.Tag = this.iFormularioActivo;
            this.iFormularioActivo.Show();
        }
    }
}
