namespace system_ACXAJY.Entities
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; } = null!;
        public int IdCategoria { get; set; }
        public float PrecioProducto { get; set; }
        public string DescripcionProducto { get; set; } = null!;
        public int CantidadProducto { get; set; }
    }
}
