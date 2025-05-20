using Biblioteca.Domain.Interfaces.Repositories;
using Biblioteca.Infrastructure.Data;
using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Domain.ValueObjects;

namespace Biblioteca.Infrastructure.Repositories
{
    public class LibroRepository : ILibroRepository
    {
        private readonly BibliotecaDbContext _context;

        public LibroRepository(BibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Libro libro) => await _context.Libri.AddAsync(libro);
                
        public async Task<Libro?> GetByISBNAsync(string isbn)=> await _context.Libri.FirstOrDefaultAsync(l => l.Isbn == isbn);

        public async Task<IEnumerable<Libro>> GetAllAsync() => await _context.Libri.ToListAsync();

        public async Task<Libro> GetByIdAsync(Guid id) => await _context.Libri.FindAsync(id);

        public void Remove(Libro libro) => _context.Libri.Remove(libro);

        public void Update(Libro libro) => _context.Libri.Update(libro);

        public Task<bool> ExistsAsync(string isbn) => _context.Libri.AnyAsync<Libro>(l => l.Isbn == isbn);        
    }
}
