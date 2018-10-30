using System.Collections.Generic;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios.InterfacesRepositorios
{
    /// <summary>
    /// Repositorio generico para el acceso a los Socios.
    /// </summary>
    public interface ISocioRepository : IRepository<Socio>
    {
        IList<Socio> GetSociosByString(string pCadena);
        IList<Socio> GetSociosActivos();
    }
}
