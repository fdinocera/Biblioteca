using Biblioteca.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ILibroRepository Libri {get;}
        IUtenteRepository  Utenti { get; }
        IPrestitoRepository Prestiti { get; }
        Task<int> CommitAsync();
    }
}
