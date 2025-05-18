using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.ValueObjects
{
    public class Email
    {
        public string Indirizzo { get; }

        public Email(string indirizzo)
        {
            if (string.IsNullOrWhiteSpace(indirizzo) || !indirizzo.Contains("@"))
                throw new ArgumentException("Email non valida");

            Indirizzo = indirizzo.Trim().ToLower();
        }

        public override string ToString() =>Indirizzo;        
    }
}
