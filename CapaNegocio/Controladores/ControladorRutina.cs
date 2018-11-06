using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBaseDatos;
using CapaDominio.ModuloGimnasio;
using CapaNegocio;

namespace CapaNegocio.Controladores
{
    public class ControladorRutina
    {
        private UnitOfWork iUnitOfWork;

        public ControladorRutina() // constructor del controlador
        {
            this.iUnitOfWork = new UnitOfWork(new GimnasioBD());
        }

        public void NuevoEjercicio(string nombre) // constructor de ejercicio
        {
            var unEjercicio = new Ejercicio(); // instanciacion de nuevo ejercicio
            this.iUnitOfWork.EjercicioRepository.Add(unEjercicio); // agregarEjercicio a listEjercicios
        }

        public void NuevoMusculo(string nombre) // constructor de musculo
        {
            var unMusculo = new Musculo(nombre); // instanciacion de nuevo musculo
            this.iUnitOfWork.MusculoRepository.Add(unMusculo); // agregarMusculo a listMusculo
        }

        public LineaEjercicio NuevaLineaEjercicio(int musculoId, int ejercicioId, string serieRepeticion, int descanso) // agregar "renglon" de ejercicio
        {
            var unMusculo = this.iUnitOfWork.MusculoRepository.Get(musculoId); // obtener musculo del repositorio
            var unEjercicio = this.iUnitOfWork.EjercicioRepository.Get(ejercicioId); // obtener ejercicio del repositorio
            
            LineaEjercicio unaLinea = new LineaEjercicio(unMusculo, unEjercicio, serieRepeticion, descanso); // cargar musculo y ejercicio en lineaEjercicio
            return unaLinea;
        }

        public DiaRutina NuevoDiaRutina(int dia, Rutina unaRutina) // constructor de bloque de dia de rutina
        {
            var unDiaRutina = new DiaRutina(dia, unaRutina);

            return unDiaRutina;
        }

        public Rutina AltaRutina(string nombre, int duracion, DateTime fechaInicio)
        {
            var unaRutina = new Rutina(nombre, duracion, fechaInicio);
            return unaRutina;
        }

        public List<Rutina> BuscarRutina(string nombre)
        {
            var lista = this.iUnitOfWork.RutinaRepository.GetAll();
            return lista.Where(unaRutina => unaRutina.Nombre.Contains(nombre)).ToList();
        }

        public void BajaRutina(int rutinaId)
        {
            var unaRutina = this.iUnitOfWork.RutinaRepository.Get(rutinaId);

            this.iUnitOfWork.RutinaRepository.Remove(unaRutina);
        }

        public void ModificarRutina(int rutinaId, string nombre, int duracion, DateTime fechaInicio)
        {
            var unaRutina = this.iUnitOfWork.RutinaRepository.Get(rutinaId);

            unaRutina.Nombre = nombre;
            unaRutina.CantDias = duracion;
            unaRutina.FecInicio = fechaInicio;

        }

        public void AsociarRutinaASocio(int rutinaId, int socioDni)
        {

            var unaRutina = this.iUnitOfWork.RutinaRepository.Get(rutinaId);
            var unSocio = this.iUnitOfWork.SocioRepository.Get(socioDni);

            unSocio.Rutinas.Add(unaRutina);
           // unaRutina.Socios.Add(unSocio);
        }

        public List<Musculo> GetMusulos()
        {
            List<Musculo> lista = this.iUnitOfWork.MusculoRepository.GetAll().ToList();
            return lista;
        }

        public List<Ejercicio> GetEjercicios()
        {
            List<Ejercicio> lista = this.iUnitOfWork.EjercicioRepository.GetAll().ToList();
            return lista;
        }
        
       
    }
}
