using Biblioteca.Application.DTOs;
using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca.Application.Services
{
    public class PrestitoService : IPrestitoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public PrestitoService(IUnitOfWork unitOfWork, ILogger<LibroService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task AggiungiPrestitoAsync(string email, string isbn)
        {
            var prestito = new Prestito(email, isbn, DateTime.Now);

            await _unitOfWork.Prestiti.AddAsync(prestito);
            await _unitOfWork.CommitAsync();
        }
    }
}
