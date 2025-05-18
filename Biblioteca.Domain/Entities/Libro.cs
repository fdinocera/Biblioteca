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
        public Guid Id { get; private set; }= Guid.NewGuid();
        public string Titolo { get; private set; }
        public Isbn Isbn { get; private set; }
        public bool Disponibile { get; private set; } = true;

        public Libro(string titolo, Isbn isbn) { 
            Titolo = titolo;
            Isbn = isbn;
        }

        public void SegnaComeNonDisponibile() => Disponibile = false;
        public void SegnaComeDisponibile()=>Disponibile = true;

    }
}
