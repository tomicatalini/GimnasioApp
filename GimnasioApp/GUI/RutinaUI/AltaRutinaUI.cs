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

        public void AgregarDataGrid()
        {
            var nuevoDataGrid = new DataGridDiaRutina();
            this.iCantidadDias += 1;
            nuevoDataGrid.Width = this.panelContenedor.Width - (this.panelContenedor.Padding.Right * 2);
            nuevoDataGrid.Controls["lblTextoDia"].Text = "0"+this.iCantidadDias;
            this.panelContenedor.Controls.Add(nuevoDataGrid);
            nuevoDataGrid.Show();
        }

        private void btnAgregarDia_Click(object sender, EventArgs e)
        {
            AgregarDataGrid();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var adminRutina = new ControladorRutina();
            var btn = (Button)sender;
            var altaRutinaUI = btn.Parent;
            var panelContenedor = altaRutinaUI.Controls["panelContenedor"];
            List<object> listaDias = new List<object>();

            foreach (var control in panelContenedor.Controls)
            {
                if (control is DataGridDiaRutina)
                {
                    DataGridDiaRutina controlUsuario = (DataGridDiaRutina)control;
                    var dia = int.Parse(controlUsuario.Controls["lblTextoDia"].Text.Trim());
                    var nombreDia = controlUsuario.Controls["txtNombreDia"].Text.Trim();
                    var dataGrid = (DataGridView)controlUsuario.Controls["dataGridDia"];

                    foreach (DataGridViewRow item in dataGrid.Rows)
                    {
                        string musculo = item.Cells["musculo"].Value.ToString();
                        string ejercicio = item.Cells["Ejercicio"].Value.ToString();
                        string series = item.Cells["serie"].Value.ToString();
                        string repeticion = item.Cells["repeticion"].Value.ToString();
                        string observacion = item.Cells["observacion"].Value.ToString();
                        int descanso = int.Parse(item.Cells["descanso"].Value.ToString());

                        listaDias.Add(adminRutina.ObtenerRutinaDeDataGrid(dia, nombreDia, musculo, ejercicio, series, repeticion, observacion, descanso));
                    }

                    
                }
            }


           
        }
    }
}
