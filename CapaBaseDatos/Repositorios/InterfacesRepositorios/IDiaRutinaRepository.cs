using System.Collections.Generic;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios.InterfacesRepositorios
{
    /// <summary>
    /// Repositorio generico para el acceso a los Dias de la Rutina.
    /// </summary>
    public interface IDiaRutinaRepository : IRepository<DiaRutina>
    {
        IList<DiaRutina> GetDiaByNum(int num);
    }
}