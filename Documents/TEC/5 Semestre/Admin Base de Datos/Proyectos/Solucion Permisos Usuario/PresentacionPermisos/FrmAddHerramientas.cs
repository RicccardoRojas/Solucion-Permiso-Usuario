using System;
using System.Windows.Forms;
using ManejadorPermisos;
using EntidadPermisos;

namespace PresentacionPermisos
{
    public partial class FrmAddHerramientas : Form
    {
        ManejadorHerramientas MH;
        public FrmAddHerramientas()
        {
            InitializeComponent();
            MH = new ManejadorHerramientas();
            if (FrmHerramientas.herramientas.CodigoHerramienta>0)
            {
                txtNombre.Text = FrmHerramientas.herramientas.Nombre;
                txtMedida.Text = FrmHerramientas.herramientas.Medida.ToString();
                txtMarca.Text = FrmHerramientas.herramientas.Marca;
                txtDescripcion.Text = FrmHerramientas.herramientas.Descripcion;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MH.Guardar(new Herramientas(FrmHerramientas.herramientas.CodigoHerramienta,txtNombre.Text,double.Parse(txtMedida.Text),
                txtMarca.Text,txtDescripcion.Text));
            Close();
        }
    }
}
