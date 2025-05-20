using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Domain.Entities;
using Biblioteca.Domain.ValueObjects;

namespace Biblioteca.Domain.Interfaces.Repositories
{
    public interface ILibroRepository
    {
        Task<Libro?> GetByIdAsync(Guid id);
        Task<Libro?> GetByISBNAsync(string isbn);
        Task<IEnumerable<Libro>> GetAllAsync();
        Task AddAsync(Libro libro);
        void Update(Libro libro);
        void Remove(Libro libro);
        Task<bool> ExistsAsync(string isbn);
    }
}
