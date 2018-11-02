﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GimnasioApp.GUI.RutinaUI;
using GimnasioApp.GUI.GastoAdministrativoUI;

namespace GimnasioApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PantallaCarga());
            //Application.Run(new ProbandoFormularioPrincipal());

            ///Application.Run(new AltaRutinaUI());
            Application.Run(new AltaGastoAdministrativoUI());
        }
    }
}
