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

        public MainForm(LibroService libroService)
        {
            InitializeComponent();
            _libroService = libroService;

        }

        private void CaricaLibri()
        {
            var libri = _libroService.ElencaLibriAsync();
            dataGridView1.DataSource = libri;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CaricaLibri();
        }
    }
}
