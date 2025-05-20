using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Domain.Entities;


namespace Biblioteca.Application.DTOs
{
    public class PrestitoDto
    {
        public Libro libro { get; set; }
        public Utente utente { get; set; }
        public DateTime dataPrestito {  get; set; } 
        public DateTime? dataRestituzione { get;set; }
    }
}
