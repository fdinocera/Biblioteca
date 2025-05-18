using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.ValueObjects
{
    public class Isbn
    {
        public string Valore { get; }

        public Isbn(string valore)
        {
            if (string.IsNullOrWhiteSpace(valore))
                throw new ArgumentException("ISBN non valido");
            Valore = valore.Trim();
        }

        public override string ToString() => Valore;
    }
}
