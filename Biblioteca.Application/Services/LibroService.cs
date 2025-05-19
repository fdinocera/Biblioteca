using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Biblioteca.Application.DTOs;
using Biblioteca.Domain.Entities;


namespace Biblioteca.Application.Services
{
    public class LibroService : IGestioneLibriService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<LibroService> _logger;

        public LibroService(IUnitOfWork unitOfWork, ILogger<LibroService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<List<LibroDto>> ElencaLibriAsync()
        {
            var libri = await _unitOfWork.Libri.GetAllAsync();
            return libri.Select(l => new LibroDto
            {
                Id = l.Id,
                Titolo = l.Titolo,
                Isbn = l.Isbn,
                Disponibile = l.Disponibile
            }).ToList();
        }

        public async Task AggiungiLibroAsync(string titolo, string isbn)
        {
            var libro = new Libro(titolo, isbn);
            await _unitOfWork.Libri.AddAsync(libro);
            await _unitOfWork.CommitAsync();

        }

        public async Task SegnaComeDisponibile(Guid id)
        {
            var libro= await _unitOfWork.Libri.GetByIdAsync(id);
            if (libro == null) throw new Exception("Libro non trovato");
            libro.SegnaComeDisponibile();
            await _unitOfWork.CommitAsync();
        }

        public async Task SegnaComeNonDisponibile(Guid id)
        {
            var libro = await _unitOfWork.Libri.GetByIdAsync(id);
            if (libro == null) throw new Exception("Libro non trovato");
            libro.SegnaComeNonDisponibile();
            await _unitOfWork.CommitAsync();
        }

        
    }
}
