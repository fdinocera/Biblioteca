using Biblioteca.Domain.Interfaces;
using Biblioteca.Domain.Interfaces.Repositories;
using Biblioteca.Infrastructure.Data;
using Biblioteca.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        BibliotecaDbContext _context;

        public ILibroRepository Libri { get; }
        public IUtenteRepository Utenti { get; }
        public IPrestitoRepository Prestiti { get; }

        public UnitOfWork(BibliotecaDbContext context)
        {
            _context = context;
            Libri = new LibroRepository(context);
            Utenti = new UtenteRepository(context);
            Prestiti = new PrestitoRepository(context);
        }

        public async Task<int> CommitAsync() =>
            await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
