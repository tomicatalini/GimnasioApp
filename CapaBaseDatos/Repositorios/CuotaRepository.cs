using CapaDominio.ModuloGimnasio;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;

namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad Cuota
    /// </summary>
    public class CuotaRepository : Repository<Cuota, GimnasioBD>, ICuotaRepository
    {
        public CuotaRepository(GimnasioBD pContext) : base(pContext) { }

        /*public float GetDeuda()
        {
            float deuda = 0;
            deuda += recorrer this.iDbContext.Cuota.Pagos;
            return deuda
        }*/

    }
}
