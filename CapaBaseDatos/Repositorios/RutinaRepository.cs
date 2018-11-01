using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaDominio.ModuloGimnasio;
using System.Collections.Generic;

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
            return this.iDbContext.Rutinas.Where(unaRutina => unaRutina.Nombre.Contains(cadena));
        }
    }

}
