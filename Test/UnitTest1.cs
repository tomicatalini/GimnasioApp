using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaBaseDatos;
using CapaDominio.ModuloGimnasio;
using System.ComponentModel;
using CapaNegocio.Controladores;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            using (var db = new GimnasioBD())
            {

                Socio pSocio = new Socio
                {
                    NroSocio = 1,
                    DNI = 37563820,
                    Nombre = "Tomas",
                    Apellido = "Catalini",
                    FecNacimiento = new DateTime(1995, 03, 11),
                    Domicilio = @"suipacha 345 Dpto 10 'D'",
                    Telefono = 3442484960,
                    Mail = "tomascatalini@gmail.com",
                    Activo = true,
                    Cuotas = new List<Cuota>(),
                    Rutinas = new List<Rutina>(),
                    HistorialMedico = new List<FichaMedica>()

                };

                Cuota cuota1 = new Cuota
                {
                    NroCuota = 1,
                    Socio = pSocio,
                    SocioDNI = pSocio.DNI,
                    Año = 2018,
                    Mes = "10",
                    Descripcion = "Cuota correspondiente al mes de Octubre de 2018",
                    Monto = 450,
                    FecEmision = DateTime.Today,
                    Pagos = new List<Pago>(),
                    Pagada = false
                };

                db.Cuotas.Add(cuota1);

                Cuota cuota2 = new Cuota
                {
                    NroCuota = 1,
                    Socio = pSocio,
                    SocioDNI = pSocio.DNI,
                    Año = 2018,
                    Mes = "11",
                    Descripcion = "Cuota correspondiente al mes de Noviembre de 2018",
                    Monto = 450,
                    FecEmision = DateTime.Today,
                    Pagos = new List<Pago>(),
                    Pagada = false
                };

                db.Cuotas.Add(cuota2);

                pSocio.Cuotas.Add(cuota1);
                pSocio.Cuotas.Add(cuota2);

                db.Socios.Add(pSocio);
                db.SaveChanges();
                
            }

            using (var db = new GimnasioBD())
            {

                

                var algo = db.Socios.Include("Cuotas");
                var elSocio = db.Socios.Find(1);

                Assert.IsNotNull(elSocio);
            }
        }
    }
}
