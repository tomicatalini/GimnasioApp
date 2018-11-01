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
using GimnasioApp.GUI;

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
            var formulario = FormularioSegunBoton(btn.Name);
            AbrirFormularioHijo(formulario);
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

        public Form FormularioSegunBoton(string nombreBoton)
        {
            switch (nombreBoton)
            {
                case "btnInicio":
                    return new InicioUI();
                case "btnSocio":
                    return null;
                case "btnProducto":
                    return new InventarioProductoUI(false);
                case "btnCuota":
                    return null;
                case "btnRutina":
                    return null;
                case "btnGestion":
                    return null;
                case "btnComprarProd":
                    return new CompraVentaProductoUI("Compra");
                case "btnVenderProd":
                    return new CompraVentaProductoUI("Venta");                

                default:
                    return null;
            }
        }
    }
}
