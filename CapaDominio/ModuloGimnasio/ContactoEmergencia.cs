using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.ModuloGimnasio
{
    public class ContactoEmergencia
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }
        public long Telefono { get; set; }

        //Relationship navigation
        public virtual int FichaId { get; set; }
        public virtual FichaMedica FichaMedica { get; set; }

        /// <summary>
        /// Constructor ConctactoEmergencia
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pNombre"></param>
        /// <param name="pTelefono"></param>
        /// <param name="pFichaID"></param>
        public ContactoEmergencia(int pId, string pNombre, long pTelefono, FichaMedica pFichaMedica)
        {
            Id = pId;
            Nombre = pNombre;
            Telefono = pTelefono;
            FichaId = pFichaMedica.FichaId;
        }
    }

}
