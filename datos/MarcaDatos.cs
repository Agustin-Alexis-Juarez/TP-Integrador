using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace datos
{
    public class MarcaDatos
    {
        public List<Marca> listar()
        {
			AccesoDatos datos = new AccesoDatos();
			try
			{
				List<Marca> lista = new List<Marca>();

				datos.setearConsulta("select Id, Descripcion from MARCAS");
				datos.ejecutarLectura();

				while(datos.Lector.Read())
				{
					Marca marca = new Marca();
					marca.id = (int)datos.Lector["Id"];
					marca.Descripcion = (string)datos.Lector["Descripcion"];
					lista.Add(marca);
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
