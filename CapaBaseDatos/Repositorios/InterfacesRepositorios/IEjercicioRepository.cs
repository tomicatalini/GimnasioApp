using System.Collections.Generic;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios.InterfacesRepositorios
{
    public interface IEjercicioRepository : IRepository<Ejercicio>
    {
        IList<Ejercicio> GetEjerciciosByNombre(string cadena);
    }
}
