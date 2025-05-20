using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class Prestito
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        //public string UtenteId { get; private set; }
        
        public string Email { get; private set; }
        
        
        
        //public string LibroId { get; private set; }
        
        public string Isbn { get; private set; }
        
        
        public DateTime DataPrestito { get; private set; } = DateTime.UtcNow;
        public DateTime? DataRestituzione { get; private set; }

        public Prestito(string email, string isbn, DateTime dataPrestito)
        {
            Email = email;
            Isbn= isbn;
            DataPrestito = dataPrestito;
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
