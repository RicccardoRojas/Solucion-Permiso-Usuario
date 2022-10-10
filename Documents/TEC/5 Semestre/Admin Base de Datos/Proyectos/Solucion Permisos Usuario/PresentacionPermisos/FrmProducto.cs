using System;
using System.Windows.Forms;
using ManejadorPermisos;
using EntidadPermisos;

namespace PresentacionPermisos
{
    public partial class FrmProducto : Form
    {
        ManejadorProducto MP;
        public static Producto producto = new Producto(0,"","","");
        int col = 0, fila = 0;
        string pu = ManejadorSesion.puesto;
        public FrmProducto()
        {
            InitializeComponent();
            MP = new ManejadorProducto();
            Validar();
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto.CodigoBarras = int.Parse(dtgProductos.Rows[fila].Cells[0].Value.ToString());
            producto.Nombre = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            producto.Descripcion = dtgProductos.Rows[fila].Cells[2].Value.ToString();
            producto.Marca = dtgProductos.Rows[fila].Cells[3].Value.ToString();
            switch (col)
            {
                case 4: {
                        FrmAddProductos FA = new FrmAddProductos();
                        FA.ShowDialog();
                        Actualizar();
                    } break;
                case 5: {
                        MP.Borrar(producto);
                        Actualizar();
                    } break;
                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto.CodigoBarras = -1;
            FrmAddProductos FA = new FrmAddProductos();
            FA.ShowDialog();
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            MP.Mostrar(dtgProductos,txtBuscar.Text);
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
