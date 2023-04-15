using datos;
using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo art = null;
        private OpenFileDialog archivo = null;

        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo seleccionado)
        {
            InitializeComponent();
            art = seleccionado;
            this.Text = "Modificar articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaDatos marcaDatos = new MarcaDatos();
            CategoriaDatos catDatos = new CategoriaDatos();
            try
            {

                cboCategoria.DataSource = catDatos.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboMarca.DataSource = marcaDatos.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                

                if(art != null)
                {
                     txtCodigo.Text = art.CodigoArticulo;
                     txtNombre.Text = art.Nombre;
                     txtDescripcion.Text = art.Descripcion;
                     txtPrecio.Text = art.Precio.ToString("N2");
                     txtImagen.Text = art.ImagenUrl;
                     cboCategoria.SelectedValue = art.categoria.id;
                     cboMarca.SelectedValue = art.marca.id;
                }
                     cargarImagen(txtImagen.Text);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloDatos artDatos = new ArticuloDatos();
            bool nombre = false, codigo = false, precio = false;
            nombre = validartTxt(txtNombre, lblxNombre);
            codigo = validartTxt(txtCodigo, lblxCodigo);
            precio = validartTxt(txtPrecio, lblxPrecio);
            if(!nombre && !codigo && !precio)
            {

            try
            {

                if (art == null)
                    art = new Articulo();
               

                    art.CodigoArticulo = txtCodigo.Text;
                    art.Nombre = txtNombre.Text;
                    art.Descripcion = txtDescripcion.Text;
                    art.Precio = decimal.Parse(txtPrecio.Text);    
                    art.ImagenUrl = txtImagen.Text;
                    art.categoria = (Categoria)cboCategoria.SelectedItem;
                    art.marca = (Marca)cboMarca.SelectedItem;
              
                
                    if (art.Id != 0)
                    {
                        artDatos.modificar(art);
                        MessageBox.Show("Modificado exitosamente");

                    }
                    else
                    {
                        artDatos.agregar(art);
                        MessageBox.Show("Agregado exitosamente.");

                    }
                    // if (archivo != null && !(txtImagen.Text.ToUpper().Contains("HTTP")))
                    //{
                    // File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + art.CodigoArticulo + "-" + archivo.SafeFileName);
                    //}

                    Close();
    
            }
           // catch (DirectoryNotFoundException)
            //{
             //   MessageBox.Show("Para guardar una imagen local por favor cree la carpeta imagen-tp-maxi en el disco C:");
            //}
             catch (SqlException)
            {
                    if (txtCodigo.Text.Length > 50)
                        MessageBox.Show("El codigo de artículo sobrepasa el limite de 50 caracteres.");
                    if (txtNombre.Text.Length > 50)
                        MessageBox.Show("El Nombre del artículo sobrepasa el limite de 50 caracteres.");
                    if (txtDescripcion.Text.Length > 150)
                        MessageBox.Show("La Descripción del artículo sobrepasa el limite de 150 caracteres.");
                    if (txtImagen.Text.Length > 1000)
                        MessageBox.Show("La url de la imagen sobrepasa el limite de 1000 caracteres.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
            }
            
        }


        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxImagen.Load("https://www.campana.gob.ar/wp-content/uploads/2022/05/placeholder-1.png");
            }
        }
        private void btnImagen_Click(object sender, EventArgs e)
        {
                archivo = new OpenFileDialog();  
            
                archivo.Filter = "jpg|*.jpg;|png|*.png";
                if(archivo.ShowDialog() == DialogResult.OK)
                {
                 txtImagen.Text = archivo.FileName;
                  cargarImagen(archivo.FileName);
                }

          
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
                lblxNombre.Visible = true;
            else
                lblxNombre.Visible = false;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text))
            e.Handled = char.IsWhiteSpace(e.KeyChar);
             
        }

      
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text))
                lblxPrecio.Visible = true;
            else
                lblxPrecio.Visible = false;
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
                lblxCodigo.Visible = true;
            else
                lblxCodigo.Visible = false;
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
                e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private bool validartTxt(TextBox text, Label lbl)
        {
            if(string.IsNullOrEmpty(text.Text))
            {
                lbl.Visible = true;
                return true;
            }

            return false;
        }

    }



}
