using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Application.DTOs;


namespace Biblioteca.Application.Interfaces
{
    public interface ILibroService
    {
        Task<List<LibroDto>> ElencaLibriAsync();
        Task<bool> ExistsByIsbnAsync(string isbn);
        Task AggiungiLibroAsync(string titolo, string autore, string isbn);
        Task SegnaComeDisponibileAsync(string isbn);
        Task SegnaComeNonDisponibileAsync(string isbn);
    }
}
