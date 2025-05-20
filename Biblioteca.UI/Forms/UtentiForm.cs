using Biblioteca.Application.DTOs;
using Biblioteca.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.UI.Forms
{
    public partial class UtentiForm : Form
    {
        private readonly UtenteService _utenteService;

        public UtentiForm(UtenteService utenteService)
        {
            InitializeComponent();
            _utenteService = utenteService;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            var Nome = textBox1.Text;
            var email = textBox2.Text;
            var nuovoUtente = new UtenteDTO();
            nuovoUtente.Nome = Nome;
            nuovoUtente.Email = email;

            _utenteService.RegistraUtente(nuovoUtente);            
        }
    }
}
