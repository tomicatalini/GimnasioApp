using System;
using System.Collections.Generic;
using System.Linq;
using CapaBaseDatos.Repositorios.InterfacesRepositorios;
using CapaDominio.ModuloGimnasio;

namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad dia de la rutina
    /// </summary>
    public class DiaRutinaRepository : Repository<DiaRutina, GimnasioBD>, IDiaRutinaRepository
    {
        public DiaRutinaRepository(GimnasioBD pContext) : base(pContext) { }

        public IList<DiaRutina> GetDiaByNum(int num)
        {
            return this.iDbContext.DiasRutina.Where(unDia => unDia.Dia == num);
        }
    }
}
