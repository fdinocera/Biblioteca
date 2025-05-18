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
        public NomeCompleto Nome { get; private set; }
        public Email Email { get; private set; }
        
        public Utente(NomeCompleto nome, Email email) {
            Nome = nome;
            Email = email;        
        }
    }
}
