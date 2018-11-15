using System.Collections.Generic;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios.InterfacesRepositorios
{
    /// <summary>
    /// Repositorio generico para el acceso a las Rutinas
    /// </summary>
    public interface IRutinaRepository : IRepository<Rutina>
    {
        IList<Rutina> GetByNombre(string cadena);
    }
}
