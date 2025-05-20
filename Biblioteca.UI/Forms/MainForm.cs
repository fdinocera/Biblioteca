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
    public partial class MainForm : Form
    {
        private readonly LibroService _libroService;
        private readonly UtenteService _utenteService;
        private readonly PrestitoService _prestitoService;

        public MainForm(LibroService libroService, UtenteService utenteService, PrestitoService prestitoService)
        {
            InitializeComponent();
            _libroService = libroService;
            _utenteService = utenteService;
            _prestitoService = prestitoService;
        }

        private async void CaricaLibri()
        {
            var libri = await _libroService.ElencaLibriAsync();
            dataGridView1.DataSource = libri;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CaricaLibri();
        }

        private void btn_AggiungiLibro_Click(object sender, EventArgs e)
        {
            var libriForm = new LibriForm(_libroService);
            libriForm.ShowDialog();
        }

        private void btn_AggiungiUtente_Click(object sender, EventArgs e)
        {
            var utentiForm = new UtentiForm(_utenteService);
            utentiForm.ShowDialog();
        }

        private void btn_AggiungiPrestito_Click(object sender, EventArgs e)
        {
            var prestitoForm = new PrestitoForm(_prestitoService);
            prestitoForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
