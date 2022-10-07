namespace EntidadPermisos
{
    public class Login
    {
        public Login(int iDLogin, int fKIDUsuario, string contraseña)
        {
            IDLogin = iDLogin;
            FKIDUsuario = fKIDUsuario;
            Contraseña = contraseña;
        }

        public int IDLogin { get; set; }
        public int FKIDUsuario { get; set; }
        public string Contraseña { get; set; }
    }
}
