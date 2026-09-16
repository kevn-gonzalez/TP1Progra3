using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP1_Articulos
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaDatos marcaDatos = new MarcaDatos();
            CategoriaDatos categoriaDatos = new CategoriaDatos();

            try
            {
                cboMarca.DataSource = marcaDatos.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaDatos.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulos nuevo = new Articulos();
            ArticuloDatos datos = new ArticuloDatos();

            try
            {
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);
                nuevo.ImagenUrl = txtImagenUrl.Text;
                nuevo.IdMarca = (Marcas)cboMarca.SelectedItem;
                nuevo.IdCategoria = (Categorias)cboCategoria.SelectedItem;

                datos.Agregar(nuevo);

                MessageBox.Show("Artículo agregado correctamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
