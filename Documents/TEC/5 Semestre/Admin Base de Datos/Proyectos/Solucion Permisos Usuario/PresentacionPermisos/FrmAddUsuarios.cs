using System;
using System.Windows.Forms;
using ManejadorPermisos;
using EntidadPermisos;

namespace PresentacionPermisos
{
    public partial class FrmAddUsuarios : Form
    {
        ManejadorUsuarios MU;
        public FrmAddUsuarios()
        {
            InitializeComponent();
            MU = new ManejadorUsuarios();
            if (FrmUsuarios.usuarios.IDUsuario>0)
            {
                txtNombre.Text = FrmUsuarios.usuarios.Nombre;
                txtApellidoP.Text = FrmUsuarios.usuarios.ApellidoP;
                txtApellidoM.Text = FrmUsuarios.usuarios.ApellidoM;
                dtpNacimento.Text = FrmUsuarios.usuarios.FechaNacimiento;
                txtRFC.Text = FrmUsuarios.usuarios.RFC;
                cmbModulo.Text = FrmUsuarios.usuarios.Modulo;
                cmbPuesto.Text = FrmUsuarios.usuarios.Puesto;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MU.Guardar(new Usuarios(FrmUsuarios.usuarios.IDUsuario, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, 
                dtpNacimento.Text, txtRFC.Text, cmbModulo.Text, cmbPuesto.Text));
            Close();
        }
    }
}
