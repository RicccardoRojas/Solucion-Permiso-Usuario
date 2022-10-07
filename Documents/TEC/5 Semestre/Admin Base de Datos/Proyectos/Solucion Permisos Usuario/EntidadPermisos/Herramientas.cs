namespace EntidadPermisos
{
    public class Herramientas
    {
        public Herramientas(int codigoHerramienta, string nombre, double medida, string marca, string descripcion)
        {
            CodigoHerramienta = codigoHerramienta;
            Nombre = nombre;
            Medida = medida;
            Marca = marca;
            Descripcion = descripcion;
        }

        public int CodigoHerramienta { get; set; }
        public string Nombre { get; set; }
        public double Medida { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
    }
}
