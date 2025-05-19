using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.DTOs
{
    public class LibroDto
    {
        public Guid Id { get; set; }
        public string Titolo { get; set; }
        public string Isbn { get; set; }
        public bool Disponibile { get; set; }
    }
}
