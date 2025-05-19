using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces.Repositories;
using Biblioteca.Domain.ValueObjects;
using Biblioteca.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infrastructure.Repositories
{
    public class UtenteRepository : IUtenteRepository
    {
        private readonly BibliotecaDbContext _context;

        public UtenteRepository(BibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task<Utente?> GetByIdAsync(Guid id) =>
            await _context.Utenti.FindAsync(id);

        public async Task<IEnumerable<Utente>> GetAllAsync() =>
             await _context.Utenti.ToListAsync();

        public async Task AddAsync(Utente utente) => await _context.Utenti.AddAsync(utente);
        public void Remove(Utente utente) => _context.Utenti.Remove(utente);
        public void Update(Utente utente) => _context.Utenti.Update(utente);
        public async Task<bool> ExistsAsync(string email) =>
            await _context.Utenti.AnyAsync(u => u.Email == email);
    }
}
