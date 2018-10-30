using System;

namespace CapaDominio.ModuloComercio
{
    public class GastoAdministrativo
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public float PrecioUnitario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
