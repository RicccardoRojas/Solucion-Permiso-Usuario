using System;
using System.Windows.Forms;
using EntidadPermisos;
using Crud;
using AccesoDatosPermisos;
using System.Drawing;

namespace ManejadorPermisos
{
    public class ManejadorUsuarios : IManejador
    {
        Grafico g = new Grafico();
        AccesoUsuarios AU = new AccesoUsuarios();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format(
                    string.Format("¿Estas Seguro de Borrar: {0}?", Entidad.Nombre)),
                "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                AU.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            AU.Guardar(Entidad);
            g.Mensaje("Usuario Guardado", "¡Atencion!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = AU.Mostrar(filtro).Tables["Usuarios"];
            tabla.Columns.Insert(8, g.Boton("Editar", Color.Blue));
            tabla.Columns.Insert(9, g.Boton("Borrar", Color.Red));
        }
    }
}
