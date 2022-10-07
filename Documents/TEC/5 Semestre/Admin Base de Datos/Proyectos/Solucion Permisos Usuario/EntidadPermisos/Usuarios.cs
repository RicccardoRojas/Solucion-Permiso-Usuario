namespace EntidadPermisos
{
    public class Usuarios
    {
        public Usuarios(int iDUsuario, string nombre, string apellidoP, string apellidoM, string fechaNacimiento, string rFC, string modulo, string puesto)
        {
            IDUsuario = iDUsuario;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            FechaNacimiento = fechaNacimiento;
            RFC = rFC;
            Modulo = modulo;
            Puesto = puesto;
        }

        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string FechaNacimiento { get; set; }
        public string RFC { get; set; }
        public string Modulo { get; set; }
        public string Puesto { get; set; }
    }
}
