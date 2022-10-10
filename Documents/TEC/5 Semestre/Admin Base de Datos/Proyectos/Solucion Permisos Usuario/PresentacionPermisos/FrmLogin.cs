using System;
using System.Windows.Forms;
using ManejadorPermisos;

namespace PresentacionPermisos
{
    public partial class FrmLogin : Form
    {
        ManejadorSesion MS;
        public FrmLogin()
        {
            InitializeComponent();
            MS = new ManejadorSesion();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            string r = MS.Validar(txtUsuario, txtContraseña);
            if (r == "SI")
            {   
                FrmMenu FM = new FrmMenu();
                FM.ShowDialog();
                lblResultado.Text = MS.Validar(txtUsuario, txtContraseña);
                Close();
            }
            else
            {
                lblResultado.Text = "Usuario o Contraseña Incorrectos";
            }
        }
    }
}
