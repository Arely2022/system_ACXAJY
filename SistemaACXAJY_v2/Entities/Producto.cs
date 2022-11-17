namespace system_ACXAJY.Entities
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; } = null!;
        public string DescripcionProducto { get; set; } = null!;
        public float PrecioProducto { get; set; }
        public int IdCategoria { get; set; }
        public int CantidadProducto { get; set; }
    }
}
