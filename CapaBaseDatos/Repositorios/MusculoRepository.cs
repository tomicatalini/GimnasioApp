using System.Collections.Generic;
using System.Linq;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad musculo
    /// </summary>
    public class MusculoRepository : Repository<Musculo, GimnasioBD>, IMusculoRepository
    {
        public MusculoRepository(GimnasioBD pContext) : base(pContext) { }

        public IList<Musculo> GetMusculosByString(string cadena)
        {
            return this.iDbContext.Musculos.Where(unMusculo => unMusculo.Nombre.Contains(cadena)).ToList();
        }
    }
}
