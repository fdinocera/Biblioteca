using Biblioteca.Domain.Entities;
using Biblioteca.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Interfaces.Repositories
{
    public interface IUtenteRepository
    {
        Task<Utente?> GetByIdAsync(Guid guid);
        Task<IEnumerable<Utente>> GetAllAsync();
        Task AddAsync(Utente utente);
        void Remove(Utente utente);
        void Update(Utente utente);
        Task<bool> ExistsAsync(string email);
    }
}
