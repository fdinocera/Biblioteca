using Biblioteca.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Domain.Entities;
using Biblioteca.Infrastructure.Data;

namespace Biblioteca.Infrastructure.Repositories
{
    public class PrestitoRepository : IPrestitoRepository
    {
        private readonly BibliotecaDbContext _context;

        public PrestitoRepository(BibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Prestito prestito) => await _context.AddAsync(prestito);

        public async Task<IEnumerable<Prestito>> GetByLibroIdAsync(string isbn) =>
            await _context.Prestiti.Where(p => p.Isbn == isbn).ToListAsync();

        public async Task<IEnumerable<Prestito>> GetByUtenteIdAsync(string email) =>
            await _context.Prestiti.Where(p => p.Email == email).ToListAsync();

        public async Task<Prestito> GetByIdAsync(Guid id) =>
            await _context.Prestiti.FindAsync(id);

        public void Remove(Prestito prestito) => _context.Prestiti.Remove(prestito);

        public void Update(Prestito prestito) => _context.Prestiti.Update(prestito);

        public async Task<IEnumerable<Prestito>> GetAllAsync() =>
            await _context.Prestiti.ToListAsync();

    }
}
