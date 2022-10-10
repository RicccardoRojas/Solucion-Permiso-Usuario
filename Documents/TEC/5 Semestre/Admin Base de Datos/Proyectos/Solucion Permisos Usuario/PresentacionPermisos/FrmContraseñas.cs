using System;
using System.Windows.Forms;
using ManejadorPermisos;
using EntidadPermisos;

namespace PresentacionPermisos
{
    public partial class FrmContraseñas : Form
    {
        ManejadorLogin ML;
        int col = 0, fila = 0;
        public static Login login = new Login(0,0,"");
        public static string Loginh;
        public FrmContraseñas()
        {
            InitializeComponent();
            ML = new ManejadorLogin();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            FrmUsuarios FU = new FrmUsuarios();
            FU.ShowDialog();
        }

        private void dtgContraseñas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            col = e.ColumnIndex;
            fila = e.RowIndex;
        }

        private void dtgContraseñas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            login.IDLogin = int.Parse(dtgContraseñas.Rows[fila].Cells[0].Value.ToString());
            Loginh = dtgContraseñas.Rows[fila].Cells[1].Value.ToString();
            login.Contraseña = dtgContraseñas.Rows[fila].Cells[2].Value.ToString();
            switch (col)
            {
                case 3: {
                        FrmAddContraseñas FC = new FrmAddContraseñas();
                        FC.ShowDialog();
                        Actualizar();
                    } break;
                case 4: {
                        ML.Borrar(login);
                        Actualizar();
                    } break;
                default:
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            login.IDLogin = -1;
            FrmAddContraseñas FC = new FrmAddContraseñas();
            FC.ShowDialog();
            Actualizar();
        }

        void Actualizar()
        {
            ML.Mostrar(dtgContraseñas,txtBuscar.Text);
        }
    }
}
