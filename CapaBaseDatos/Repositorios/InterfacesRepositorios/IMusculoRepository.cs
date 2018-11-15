using System.Collections.Generic;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios.InterfacesRepositorios
{
    /// <summary>
    /// Repositorio generico para el acceso a los Musculos.
    /// </summary>
    public interface IMusculoRepository : IRepository<Musculo>
    {
        IList<Musculo> GetMusculosByString(string cadena);
    }
}
