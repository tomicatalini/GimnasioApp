using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios
{
    public class EjercicioRepository : Repository<Ejercicio, GimnasioBD>, IEjercicioRepository
    {
        public EjercicioRepository(GimnasioBD pContext) : base(pContext) { }
    }
}
