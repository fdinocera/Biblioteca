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
using Biblioteca.Application;

namespace Biblioteca.Application.Services
{
    public class UtenteService : IUtenteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UtenteService> _logger;

        public UtenteService(IUnitOfWork unitOfWork, ILogger<UtenteService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        
        public void RegistraUtente(UtenteDTO utenteDTO)
        {

            var nuovoUtente = new Utente(utenteDTO.Nome, utenteDTO.Email);
            _unitOfWork.Utenti.AddAsync(nuovoUtente);
            _unitOfWork.CommitAsync();            
        }
    }
}
