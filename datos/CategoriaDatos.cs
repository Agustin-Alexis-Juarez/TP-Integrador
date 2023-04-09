using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace datos
{
    public class CategoriaDatos
    {
        public List<Categoria> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                List<Categoria> lista = new List<Categoria>();

                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria cat = new Categoria();
                    cat.id = (int)datos.Lector["Id"];
                    cat.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(cat);
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
    }
}
