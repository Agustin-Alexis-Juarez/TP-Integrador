using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        //
        public int Id { get; set; }
        public string CodigoArticulo { get; set; }

        public string Nombre { get; set; }
        [DisplayName("Descripcíon")]
        public string Descripcion { get; set; }

        [DisplayName("Marca")]
        public Marca marca { get; set; }
        [DisplayName("Categoria")]
        public Categoria categoria { get; set; }

        public string ImagenUrl { get; set; }

        public decimal Precio { get; set; }


    }
}
