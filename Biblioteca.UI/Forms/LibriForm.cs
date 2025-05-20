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
    public partial class LibriForm : Form
    {
        private readonly LibroService _libroService;

        public LibriForm(LibroService libroService)
        {
            InitializeComponent();
            _libroService = libroService;
        }

        private async void btnSalva_Click(object sender, EventArgs e)
        {

            string Titolo = txtTitolo.Text;
            string Autore = txtAutore.Text;
            string Isbn = txtISBN.Text;
            bool Disponibile = chkDisponibile.Checked;
            if (string.IsNullOrWhiteSpace(Titolo)||
                string.IsNullOrWhiteSpace(Autore)||
                string.IsNullOrWhiteSpace(Isbn))
            {
                MessageBox.Show("Tutti i campi sono obbligatori.");
                return;
            }

            var libroExists = await _libroService.ExistsByIsbnAsync(txtISBN.Text);

            if (libroExists)
            {
                MessageBox.Show($"Il libro con isbn {txtISBN.Text} già esiste.");
                this.Close();
                return;
            }

            // Aggiunge libro
            await _libroService.AggiungiLibroAsync(Titolo, Autore, Isbn);
            
            // Salva disponibilita
            if (Disponibile)
            {
                await _libroService.SegnaComeDisponibileAsync(Isbn);
            }
            else
            {
                await _libroService.SegnaComeNonDisponibileAsync(Isbn);
            }

            MessageBox.Show("Libro salvato con successo.");
            this.Close();
        }
    }
}
