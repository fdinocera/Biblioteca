using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public  class Prestito
    {
        public Guid Id { get; private set; }    = Guid.NewGuid();   
        public Guid UtenteId { get; private set; }
        public Guid LibroId { get; private set; }
        public DateTime DataPrestito { get; private set; }= DateTime.UtcNow;
        public DateTime? DataRestituzione { get; private set; }

        public Prestito(Guid utenteId, Guid libroId)
        {
            UtenteId = utenteId;
            LibroId = libroId;
        }

        public void RegistraRestituzione()
        {
            if (DataRestituzione != null)
            {
                DataRestituzione = DateTime.UtcNow;
            }
        }

        public bool IsRestituito => DataRestituzione.HasValue;
    }
}
