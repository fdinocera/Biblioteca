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
    public class LibroService : ILibroService
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

        public async Task<bool> ExistsByIsbnAsync(string isbn)
        {
            bool exists = await _unitOfWork.Libri.ExistsAsync(isbn);

            if (exists) {
                _logger.LogWarning($"Il libro con codice isbn {isbn} già esiste.");
            }

            return exists;            
        }

        public async Task AggiungiLibroAsync(string titolo, string autore, string isbn)
        {

            if (string.IsNullOrWhiteSpace(autore))
                throw new AggregateException("L'autore è obbligatorio.");
            
            var libro = new Libro(titolo, autore, isbn);
            await _unitOfWork.Libri.AddAsync(libro);            
            await _unitOfWork.CommitAsync();
        }

        public async Task SegnaComeDisponibileAsync(string isbn)
        {
            var libro = await _unitOfWork.Libri.GetByISBNAsync(isbn);
            if (libro == null)
            {
                _logger.LogWarning($"Tentativo di aggiornare un libro non esistente: isbn {isbn}");
                throw new Exception("Libro non trovato");
            }

            libro.SegnaComeDisponibile();
            await _unitOfWork.CommitAsync();
        }

        public async Task SegnaComeNonDisponibileAsync(string isbn)
        {
            var libro = await _unitOfWork.Libri.GetByISBNAsync(isbn);
            if (libro == null) throw new Exception($"Libro con isbn {isbn} non trovato.");
            
            libro.SegnaComeNonDisponibile();
            await _unitOfWork.CommitAsync();
        }
    }
}
