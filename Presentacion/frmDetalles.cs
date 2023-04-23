using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmDetalles : Form
    {
        //
        private Articulo seleccionado;
        public frmDetalles(Articulo art)
        {
            InitializeComponent();
            seleccionado = art;
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            lblId.Text +=" "+ seleccionado.Id.ToString();
            lblCodArticulo.Text +=" " + seleccionado.CodigoArticulo;
            lblNombre.Text +=" " + seleccionado.Nombre;
            lblDescripcion.Text +=" " + seleccionado.Descripcion;
            lblMarca.Text +=" " + seleccionado.marca.Descripcion;
            lblCategoria.Text +=" " + seleccionado.categoria.Descripcion;
            lblImagen.Text +=" " + seleccionado.ImagenUrl;
            lblPrecio.Text +=" " + seleccionado.Precio.ToString("N2");
        }


    }
}
