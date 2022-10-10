using System;
using System.Windows.Forms;
using ManejadorPermisos;
using EntidadPermisos;

namespace PresentacionPermisos
{
    public partial class FrmAddContraseñas : Form
    {
        ManejadorLogin ML;
        public FrmAddContraseñas()
        {
            InitializeComponent();
            ML = new ManejadorLogin();
            ML.ExtraerTipos(cmbNombre);
            if (FrmContraseñas.login.IDLogin>0)
            {
                cmbNombre.Text = FrmContraseñas.Loginh;
                txtContraseña.Text = FrmContraseñas.login.Contraseña;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ML.Guardar(new Login(FrmContraseñas.login.IDLogin,int.Parse(cmbNombre.SelectedValue.ToString()),txtContraseña.Text));
            Close();
        }
    }
}
