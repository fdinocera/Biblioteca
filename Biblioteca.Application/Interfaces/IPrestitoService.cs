﻿using Biblioteca.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.Interfaces
{
    public interface IPrestitoService
    {
        Task AggiungiPrestitoAsync(string email, string isbn);
    }
}
