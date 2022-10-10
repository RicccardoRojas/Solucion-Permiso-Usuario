using System;
using System.Windows.Forms;
using ManejadorPermisos;
using EntidadPermisos;

namespace PresentacionPermisos
{
    public partial class FrmHerramientas : Form
    {
        ManejadorHerramientas MH;
        public static Herramientas herramientas = new Herramientas(0,"",0.0,"","");
        int col = 0, fila = 0;
        string pu = ManejadorSesion.puesto;
        public FrmHerramientas()
        {
            InitializeComponent();
            MH = new ManejadorHerramientas();
            Validar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgHerramientas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            col = e.ColumnIndex;
            fila = e.RowIndex;
        }

        private void dtgHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            herramientas.CodigoHerramienta = int.Parse(dtgHerramientas.Rows[fila].Cells[0].Value.ToString());
            herramientas.Nombre = dtgHerramientas.Rows[fila].Cells[1].Value.ToString();
            herramientas.Medida = double.Parse(dtgHerramientas.Rows[fila].Cells[2].Value.ToString());
            herramientas.Marca = dtgHerramientas.Rows[fila].Cells[3].Value.ToString();
            herramientas.Descripcion = dtgHerramientas.Rows[fila].Cells[4].Value.ToString();
            switch (col)
            {
                case 5: {
                        FrmAddHerramientas FH = new FrmAddHerramientas();
                        FH.ShowDialog();
                        Actualizar();
                    } break;
                case 6: {
                        MH.Borrar(herramientas);
                        Actualizar();
                    } break;
                default:
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            herramientas.CodigoHerramienta = -1;
            FrmAddHerramientas FH = new FrmAddHerramientas();
            FH.ShowDialog();
            Actualizar();
        }

        void Actualizar()
        {
            MH.Mostrar(dtgHerramientas,txtBuscar.Text);
        }

        void Validar()
        {
            if (pu == "Gerente")
            {
                btnAgregar.Visible = true;
            }
            if (pu == "Encargado")
            {
                btnAgregar.Visible = true;
            }
            if (pu == "Obrero")
            {
                btnAgregar.Visible = false;
            }
        }
    }
}
