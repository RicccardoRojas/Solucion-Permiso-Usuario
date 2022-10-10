using System;
using System.Windows.Forms;
using ManejadorPermisos;

namespace PresentacionPermisos
{
    public partial class FrmMenu : Form
    {
        string mo = ManejadorSesion.modulo;
        string pu = ManejadorSesion.puesto;
        public FrmMenu()
        {
            InitializeComponent();
            Validar();
        }

        private void optProductos_Click(object sender, EventArgs e)
        {
            FrmProducto FP = new FrmProducto();
            FP.ShowDialog();
        }

        private void optHerramientas_Click(object sender, EventArgs e)
        {
            FrmHerramientas FH = new FrmHerramientas();
            FH.ShowDialog();
        }

        private void optUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios FU = new FrmUsuarios();
            FU.ShowDialog();
        }
        void Validar()
        {
            if (pu == "Gerente" && (mo == "Taller" || mo == "Refacciones"))
            {
                optHerramientas.Visible = true;
                optProductos.Visible = true;
                optUsuarios.Visible = true;
            }
            if ((pu == "Obrero" || pu == "Encargado") && mo == "Taller")
            {
                optProductos.Visible = false;
                optUsuarios.Visible = false;
                optHerramientas.Visible = true;
            }
            if ((pu == "Obrero" || pu == "Encargado") && mo == "Refacciones")
            {
                optProductos.Visible = true;
                optUsuarios.Visible = false;
                optHerramientas.Visible = false;
            }
        }
    }
}
