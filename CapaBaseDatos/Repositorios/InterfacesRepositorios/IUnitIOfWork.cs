using System;

namespace CapaBaseDatos.Repositorios.InterfacesRepositorios
{
    /// <summary>
    /// Representa una transaccion con la BD
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Persiste los cambios
        /// </summary>
        void Complete();
    }
}
