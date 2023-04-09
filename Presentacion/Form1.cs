using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;
using dominio;
namespace Presentacion
{
    public partial class FrmMain : Form
    {

        private List<Articulo> listaArticulos;
        private bool filtroNumero = false;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cargarMarca();
            cargarCategoria();
            
            cboCampo.Items.Add(" ");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descricion");

        }

        private void cargar()
        {
            ArticuloDatos articulos = new ArticuloDatos();

            try
            {
                listaArticulos = articulos.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumna();
                cargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

        private void ocultarColumna()
        {
            try
            {
             
                
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["CodigoArticulo"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregar = new frmAgregarArticulo();
            agregar.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo selec = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregarArticulo modificar = new frmAgregarArticulo(selec);
            modificar.ShowDialog();
            cargar();
        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            ArticuloDatos articuloD = new ArticuloDatos();
            try
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Quieres eliminar el articulo "+ seleccionado.Nombre + "?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    articuloD.Borrar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            
                List<Articulo> listaFiltrada;
                string filtro = txtFiltrar.Text;


            if (filtro.Length >= 2)
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.marca.Descripcion.ToLower().Contains(filtro.ToLower()) || x.categoria.Descripcion.ToLower().Contains(filtro.ToLower()));
            else
                listaFiltrada = listaArticulos;


                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                ocultarColumna();
            

            
        }


        private void cargarMarca()
        {
            MarcaDatos marca = new MarcaDatos();
            List<Marca> listAux;
            try
            {
                listAux = marca.listar();
                cboMarca.Items.Add(" ");
                foreach(var item in listAux)
                {
                    cboMarca.Items.Add(item);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarCategoria()
        {
            CategoriaDatos cat = new CategoriaDatos();
            List<Categoria> listAux;
            try
            {
                listAux = cat.listar();
                cboCategoria.Items.Add(" ");
                foreach(var item in listAux)
                {
                   cboCategoria.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarCriterio()
        {
           

            if (cboCampo.Text == "Precio")
            {
                
                cboCriterio.Enabled = true;
                filtroNumero = true;
                btnBuscar.Enabled = false;
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add(" ");
                cboCriterio.Items.Add("Mayor que");
                cboCriterio.Items.Add("Menor que");
                cboCriterio.Items.Add("Igual que");
            }
            else if(cboCampo.Text == " " || cboCampo.SelectedIndex < 0)
            {
                cboCriterio.Enabled = false;
                cboMarca.Enabled = false;
                cboCategoria.Enabled = false;
                btnBuscar.Enabled = true;
            }
            else
            {
               
                cboCriterio.Enabled = true;
                filtroNumero = false;
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add(" ");
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
                
                
           
        }

        private void cboCampo_TextChanged(object sender, EventArgs e)
        {
            
            cargarCriterio();
            
        }

        private void cboCriterio_TextChanged(object sender, EventArgs e)
        {
            if (cboCriterio.SelectedItem.ToString() != " " || cboCriterio.SelectedIndex > 0)
            {
                cboMarca.Enabled = true;
                cboCategoria.Enabled = true;
                btnBuscar.Enabled = true;
            } else
            {
                cboMarca.Enabled = false;
                cboCategoria.Enabled = false;
                btnBuscar.Enabled=false;
            }
        }

        private void txtFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(filtroNumero)
            {
                if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            string filtro = txtFiltroAvanzado.Text;
            try
            {
                if((cboCampo.Text != " " || cboCampo.SelectedIndex > 0) && !(string.IsNullOrEmpty(filtro)))
                {

                    if(cboCampo.Text == "Precio")
                    {                
                        switch(cboCriterio.Text)
                            {
                                case "Mayor que":
                                    if((cboMarca.Text !=" " && cboCategoria.Text != " ") && (cboMarca.SelectedIndex > 0 && cboCategoria.SelectedIndex > 0))
                                    {
                                      
                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio > Convert.ToDecimal(filtro) && x.marca.Descripcion.ToLower().Contains(cboMarca.Text.ToLower()) && x.categoria.Descripcion.ToLower().Contains(cboCategoria.Text.ToLower()));
                                    } 
                                    else if(cboMarca.Text != " " && cboMarca.SelectedIndex > 0)
                                    {
                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio > Convert.ToDecimal(filtro) && x.marca.Descripcion.ToLower().Contains(cboMarca.Text.ToLower()));
                                    }
                                    else if(cboCategoria.Text != " " && cboCategoria.SelectedIndex > 0)
                                    {
                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio > Convert.ToDecimal(filtro) && x.categoria.Descripcion.ToLower().Contains(cboCategoria.Text.ToLower()));
                                    }
                                    else
                                    {
                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio > Convert.ToDecimal(filtro));
                                    }
                                    break;
                                case "Menor que":

                                    if ((cboMarca.Text != " " && cboCategoria.Text != " ") && (cboMarca.SelectedIndex > 0 && cboCategoria.SelectedIndex > 0))
                                    {

                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio < Convert.ToDecimal(filtro) && x.marca.Descripcion.ToLower().Contains(cboMarca.Text.ToLower()) && x.categoria.Descripcion.ToLower().Contains(cboCategoria.Text.ToLower()));
                                    }
                                    else if (cboMarca.Text != " " && cboMarca.SelectedIndex > 0)
                                    {
                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio < Convert.ToDecimal(filtro) && x.marca.Descripcion.ToLower().Contains(cboMarca.Text.ToLower()));
                                    }
                                    else if (cboCategoria.Text != " " && cboCategoria.SelectedIndex > 0)
                                    {
                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio < Convert.ToDecimal(filtro) && x.categoria.Descripcion.ToLower().Contains(cboCategoria.Text.ToLower()));
                                    }
                                    else
                                    {
                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio < Convert.ToDecimal(filtro));
                                    }

                                    break;
                                case "Igual que":

                                    if ((cboMarca.Text != " " && cboCategoria.Text != " ") && (cboMarca.SelectedIndex > 0 && cboCategoria.SelectedIndex > 0))
                                    {

                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio == Convert.ToDecimal(filtro) && x.marca.Descripcion.ToLower().Contains(cboMarca.Text.ToLower()) && x.categoria.Descripcion.ToLower().Contains(cboCategoria.Text.ToLower()));
                                    }
                                    else if (cboMarca.Text != " " && cboMarca.SelectedIndex > 0)
                                    {
                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio == Convert.ToDecimal(filtro) && x.marca.Descripcion.ToLower().Contains(cboMarca.Text.ToLower()));
                                    }
                                    else if (cboCategoria.Text != " " && cboCategoria.SelectedIndex > 0)
                                    {
                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio == Convert.ToDecimal(filtro) && x.categoria.Descripcion.ToLower().Contains(cboCategoria.Text.ToLower()));
                                    }
                                    else
                                    {
                                        listaFiltrada = listaArticulos.FindAll(x => x.Precio == Convert.ToDecimal(filtro));
                                    }

                                    break;
                            }
                    } 
                    else
                    {
                        ArticuloDatos articuloDatos = new ArticuloDatos();
                        List<Articulo> aux;
                        aux = articuloDatos.filtrar(cboCampo.Text, cboCriterio.Text, txtFiltroAvanzado.Text);

                        if ((cboMarca.Text != " " && cboCategoria.Text != " ") && (cboMarca.SelectedIndex > 0 && cboCategoria.SelectedIndex > 0))
                        {
                            listaFiltrada = aux.FindAll(x => x.marca.Descripcion.ToLower().Contains(cboMarca.Text.ToLower()) && x.categoria.Descripcion.ToLower().Contains(cboCategoria.Text.ToLower()));
                        }
                        else if(cboMarca.Text != " " && cboMarca.SelectedIndex > 0)
                        {
                            listaFiltrada = aux.FindAll(x => x.marca.Descripcion.ToLower().Contains(cboMarca.Text.ToLower()));
                        }
                        else if(cboCategoria.Text != " " && cboCategoria.SelectedIndex > 0)
                        {
                            listaFiltrada = aux.FindAll(x => x.categoria.Descripcion.ToLower().Contains(cboCategoria.Text.ToLower()));
                        }
                        else
                        {
                            listaFiltrada = aux;
                        }
                    }

                }
                else
                {
                    listaFiltrada = listaArticulos;
                }


                        dgvArticulos.DataSource = null;
                        dgvArticulos.DataSource = listaFiltrada;
                         ocultarColumna();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo art;
            try
            {
                art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalles detalles = new frmDetalles(art);
                detalles.ShowDialog();
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Seleccione un Articulo para ver detalles.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
            


            
           
        }
    }
}
