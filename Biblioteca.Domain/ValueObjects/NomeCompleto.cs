using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.ValueObjects
{
    public record NomeCompleto
    {
        public string Nome { get; }
        public string Cognome { get; }

        public NomeCompleto(string nome, string cognome)
        {
            Nome = nome.Trim();
            Cognome = cognome.Trim();
        }

        public override string ToString() => $"{Nome} {Cognome}";
    }
}
