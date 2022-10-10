using System;
using System.Windows.Forms;
using ManejadorPermisos;
using EntidadPermisos;

namespace PresentacionPermisos
{
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios MU;
        public static Usuarios usuarios = new Usuarios(0,"","","","","","","");
        int col = 0, fila = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            MU = new ManejadorUsuarios();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            col = e.ColumnIndex;
            fila = e.RowIndex;
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuarios.IDUsuario = int.Parse(dtgUsuarios.Rows[fila].Cells[0].Value.ToString());
            usuarios.Nombre = dtgUsuarios.Rows[fila].Cells[1].Value.ToString();
            usuarios.ApellidoP = dtgUsuarios.Rows[fila].Cells[2].Value.ToString();
            usuarios.ApellidoM = dtgUsuarios.Rows[fila].Cells[3].Value.ToString();
            usuarios.FechaNacimiento = dtgUsuarios.Rows[fila].Cells[4].Value.ToString();
            usuarios.RFC = dtgUsuarios.Rows[fila].Cells[5].Value.ToString();
            usuarios.Modulo = dtgUsuarios.Rows[fila].Cells[6].Value.ToString();
            usuarios.Puesto = dtgUsuarios.Rows[fila].Cells[7].Value.ToString();
            switch (col)
            {
                case 8: {
                        FrmAddUsuarios FU = new FrmAddUsuarios();
                        FU.ShowDialog();
                        Actualizar();
                    } break;
                case 9: {
                        MU.Borrar(usuarios);
                        Actualizar();
                    } break;
                default:
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuarios.IDUsuario = -1;
            FrmAddUsuarios FU = new FrmAddUsuarios();
            FU.ShowDialog();
            Actualizar();
        }

        private void btnContraseñas_Click(object sender, EventArgs e)
        {
            Close();
            FrmContraseñas FC = new FrmContraseñas();
            FC.ShowDialog();
        }

        void Actualizar()
        {
            MU.Mostrar(dtgUsuarios,txtBuscar.Text);
        }
    }
}
