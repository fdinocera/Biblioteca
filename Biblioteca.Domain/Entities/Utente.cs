using Biblioteca.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class Utente
    {
        public Guid Id { get; private set; }= Guid.NewGuid();
        public string Nome { get; private set; }
        public string Email { get; private set; }
        
        public Utente(string nome, string email) {
            Nome = nome;
            Email = email;        
        }
    }
}
