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
    public partial class PrestitoForm : Form
    {
        private readonly PrestitoService _prestitoService;

        public PrestitoForm(PrestitoService prestitoService)
        {
            InitializeComponent();
            _prestitoService = prestitoService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text;
            string isbn = textBox1.Text;

            await _prestitoService.AggiungiPrestitoAsync(email, isbn);

            MessageBox.Show("Prestito salvato con successo.");
            this.Close();
        }        
    }
}
