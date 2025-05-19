using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Application.DTOs;


namespace Biblioteca.Application.Interfaces
{
    public interface IGestioneLibriService
    {
        Task <List<LibroDto>> ElencaLibriAsync();
        Task AggiungiLibroAsync(string titolo, string isbn);
        Task SegnaComeDisponibile(Guid id);
        Task SegnaComeNonDisponibile(Guid id);
    }
}
