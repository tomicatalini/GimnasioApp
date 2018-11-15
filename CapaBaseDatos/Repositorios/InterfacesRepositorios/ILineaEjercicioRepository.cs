using System.Collections.Generic;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios.InterfacesRepositorios
{
    /// <summary>
    /// Repositorio generico para el acceso a las Lineas de Ejercicio.
    /// </summary>
    public interface ILineaEjercicioRepository : IRepository<LineaEjercicio>
    {
        IList<LineaEjercicio> GetLineaById(int id);
    }
}