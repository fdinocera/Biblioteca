using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Domain.Interfaces.Repositories
{
    public interface IPrestitoRepository
    {
        Task<Prestito> GetByIdAsync(Guid id);
        Task<IEnumerable<Prestito>> GetAllAsync();
        Task AddAsync(Prestito prestito);
        void Remove(Prestito prestito);
        void Update(Prestito prestito);
    }
}
