using System.Collections.Generic;
using System.Linq;
using CapaDominio.ModuloGimnasio;
using System;
using CapaBaseDatos;


namespace CapaBaseDatos.Repositorios
{
    /// <summary>
    /// Repositorio de entidad FichaMedica
    /// </summary>

    public class HistorialMedicoRepository : Repository<FichaMedica, GimnasioBD>, IHistorialMedicoRepository
    {

        public HistorialMedicoRepository(GimnasioBD pContext) : base(pContext) { }

        //public FichaMedica getFichaID(int pFichaID) { return ; }        
    }
}