using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace datos
{
    public class ArticuloDatos
    {

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id,Codigo, Nombre, A.Descripcion, M.Descripcion Marca, M.Id idmarca, C.Id idcat, C.Descripcion Categoria, ImagenUrl, Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where IdMarca = M.Id and IdCategoria = C.Id";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.marca = new Marca();
                    aux.marca.id = (int)datos.Lector["idmarca"];
                    aux.marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["idcat"];
                    aux.categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo art)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values(@codigo,@nombre,@descripcion,@marca,@categoria,@imagen,@precio)");
                datos.setearParametros("@marca", art.marca.id);
                datos.setearParametros("@codigo", art.CodigoArticulo);
                datos.setearParametros("@nombre", art.Nombre);
                datos.setearParametros("@descripcion", art.Descripcion);
                datos.setearParametros("@categoria", art.categoria.id);
                datos.setearParametros("@imagen", art.ImagenUrl);
                datos.setearParametros("@precio", art.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @marca, IdCategoria = @categoria, ImagenUrl = @imagen, Precio = @precio where Id = @id");
                datos.setearParametros("@id", art.Id);
                datos.setearParametros("@codigo", art.CodigoArticulo);
                datos.setearParametros("@nombre", art.Nombre);
                datos.setearParametros("@descripcion", art.Descripcion);
                datos.setearParametros("@categoria", art.categoria.id);
                datos.setearParametros("@marca", art.marca.id);
                datos.setearParametros("@imagen", art.ImagenUrl);
                datos.setearParametros("@precio", art.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }

        public void Borrar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "delete from ARTICULOS where Id = @id";            
                datos.setearConsulta(consulta);
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id,Codigo, Nombre, A.Descripcion, M.Descripcion Marca, M.Id idmarca, C.Id idcat, C.Descripcion Categoria, ImagenUrl, Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where IdMarca = M.Id and IdCategoria = C.Id and ";

                if(campo == "Nombre")
                {
                    switch(criterio)
                    {
                        case "Empieza con":
                            consulta += "Nombre like '"+filtro+"%'";
                            break;

                        case "Termina con":
                            consulta += "Nombre like '%"+filtro+"'";
                            break;

                        default:
                            consulta += "Nombre like '%"+filtro+"%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "A.Descripcion like '" + filtro + "%'";
                            break;

                        case "Termina con":
                            consulta += "A.Descripcion like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "A.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.marca = new Marca();
                    aux.marca.id = (int)datos.Lector["idmarca"];
                    aux.marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["idcat"];
                    aux.categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    listaFiltrada.Add(aux);
                }

                return listaFiltrada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
