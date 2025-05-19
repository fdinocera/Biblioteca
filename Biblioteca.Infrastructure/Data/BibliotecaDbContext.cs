using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Domain.Entities;


namespace Biblioteca.Infrastructure.Data
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : base(options) { }

        public DbSet<Libro> Libri => Set<Libro>();
        public DbSet<Utente> Utenti => Set<Utente>();
        public DbSet<Prestito> Prestiti => Set<Prestito>();
    }
}
