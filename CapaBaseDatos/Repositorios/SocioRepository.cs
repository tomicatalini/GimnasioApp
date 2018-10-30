using System.Collections.Generic;
using System.Linq;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad socio
    /// </summary>
    public class SocioRepository : Repository<Socio, GimnasioBD>, ISocioRepository
    {
        public SocioRepository(GimnasioBD pContext) : base(pContext) { }

        public IList<Socio> GetSociosByString(string pCadena)
        {
            return this.iDbContext.Socios.Where(unSocio => unSocio.Apellido.StartsWith(pCadena)).ToList();
        }

        public IList<Socio> GetSociosActivos()
        {
            return this.iDbContext.Socios.Where(unSocio => unSocio.Activo).ToList();
        }
    }
}
