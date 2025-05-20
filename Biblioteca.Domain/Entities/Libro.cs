using Biblioteca.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class Libro
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Titolo { get; private set; }
        public string Autore{ get; private set; }
        public string Isbn { get; private set; }
        public bool Disponibile { get; private set; } = true;

        public Libro() { }

        public Libro(string titolo, string autore, string isbn)
        {
            if (string.IsNullOrWhiteSpace(titolo))
                throw new ArgumentException("Il titolo non puo essere vuoto", nameof(titolo));

            if (string.IsNullOrWhiteSpace(autore))
                throw new ArgumentException("L'autore non puo essere vuoto", nameof(isbn));

            if (string.IsNullOrWhiteSpace(isbn))
                throw new ArgumentException("L'isbn non puo essere vuoto", nameof(isbn));

            Titolo = titolo;
            Autore = autore;
            Isbn = isbn;
        }

        public void SegnaComeNonDisponibile() => Disponibile = false;
        public void SegnaComeDisponibile() => Disponibile = true;
    }
}
