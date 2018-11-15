using System.Collections.Generic;
using System.Linq;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad ejercicio
    /// </summary>
    public class EjercicioRepository : Repository<Ejercicio, GimnasioBD>, IEjercicioRepository
    {
        public EjercicioRepository(GimnasioBD pContext) : base(pContext) { }

        public IList<Ejercicio> GetEjerciciosByNombre(string cadena)
        {
            return this.iDbContext.Ejercicios.Where(unEjercicio => unEjercicio.Nombre.Contains(cadena));
        }
    }
}
