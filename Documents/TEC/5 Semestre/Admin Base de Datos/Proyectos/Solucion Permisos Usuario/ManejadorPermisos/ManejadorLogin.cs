using System;
using System.Windows.Forms;
using EntidadPermisos;
using Crud;
using AccesoDatosPermisos;
using System.Drawing;

namespace ManejadorPermisos
{
    public class ManejadorLogin : IManejador
    {
        Grafico g = new Grafico();
        AccesoLogin AL = new AccesoLogin();
        AccesoUsuarios AU = new AccesoUsuarios();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format(
                    string.Format("¿Estas Seguro de Borrar: {0}?", Entidad.Nombre)),
                "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                AL.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            AL.Guardar(Entidad);
            g.Mensaje("Sesion Guardada", "¡Atencion!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = AL.Mostrar(filtro).Tables["Login"];
            tabla.Columns.Insert(3, g.Boton("Editar", Color.Blue));
            tabla.Columns.Insert(4, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }

        public void ExtraerTipos(ComboBox caja)
        {
            caja.DataSource = AU.Mostrar2().Tables["Usuarios"];
            caja.DisplayMember = "Nombre_Completo";
            caja.ValueMember = "Num_Usuario";
        }
    }
}
