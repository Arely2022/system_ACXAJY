using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_ACXAJY.Entities
{
    public class Producto
    {
        public int Idproducto { get; set; }
        public string NombreProducto { get; set; } 
        public int Idcategoria { get; set; }
        public float precioProd { get; set; }
        public string descprod { get; set; }
        public int cantidadprod { get; set; }
    }
}
