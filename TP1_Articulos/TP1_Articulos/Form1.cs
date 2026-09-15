using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP1_Articulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Articulos> listaDeArticulos = new List<Articulos>();
            ArticuloDatos Negocio = new ArticuloDatos();
            dgvPrincipal.DataSource = Negocio.Listar();
            listaDeArticulos = Negocio.Listar();
            dgvPrincipal.DataSource = listaDeArticulos;

        }
    }
}
