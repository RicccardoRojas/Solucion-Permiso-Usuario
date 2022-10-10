using System;
using System.Windows.Forms;
using ManejadorPermisos;
using EntidadPermisos;

namespace PresentacionPermisos
{
    public partial class FrmAddProductos : Form
    {
        ManejadorProducto MP;
        public FrmAddProductos()
        {
            InitializeComponent();
            MP = new ManejadorProducto();
            if (FrmProducto.producto.CodigoBarras>0)
            {
                txtCodigo.Text = FrmProducto.producto.CodigoBarras.ToString();
                txtNombre.Text = FrmProducto.producto.Nombre;
                txtDescripcion.Text = FrmProducto.producto.Descripcion;
                txtMarca.Text = FrmProducto.producto.Marca;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MP.Guardar(new Producto(int.Parse(txtCodigo.Text),txtNombre.Text,txtDescripcion.Text,txtMarca.Text));
            Close();
        }
    }
}
