using System.Collections.Generic;
using System.Linq;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad Rutina
    /// </summary>
    public class RutinaRepository : Repository<Rutina, GimnasioBD>, IRutinaRepository
    {
        public RutinaRepository(GimnasioBD pContext) : base(pContext) { }

        public IList<Rutina> GetByNombre(string cadena)
        {
          return this.iDbContext.Rutinas.Where(unaRutina => unaRutina.Nombre.Contains(cadena)).ToList();
        }

        /*public IList<Rutina> GetByNombre(string cadena)
        {
          return this.iDbContext.Rutinas.Where(unaRutina => unaRutina.Nombre.Contains(cadena));
        }*/
    }

}
