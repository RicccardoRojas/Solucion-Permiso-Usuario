namespace EntidadPermisos
{
    public class Producto
    {
        public Producto(int codigoBarras, string nombre, string descripcion, string marca)
        {
            CodigoBarras = codigoBarras;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
        }

        public int CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }

    }
}
