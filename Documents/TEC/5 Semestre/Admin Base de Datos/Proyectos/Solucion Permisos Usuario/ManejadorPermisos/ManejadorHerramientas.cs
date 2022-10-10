using System;
using System.Windows.Forms;
using EntidadPermisos;
using Crud;
using AccesoDatosPermisos;
using System.Drawing;

namespace ManejadorPermisos
{
    public class ManejadorHerramientas : IManejador
    {
        Grafico g = new Grafico();
        AccesoHerramientas AH = new AccesoHerramientas();
        string pu = ManejadorSesion.puesto;
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format(
                    string.Format("¿Estas Seguro de Borrar: {0}?", Entidad.Nombre)),
                "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                AH.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            AH.Guardar(Entidad);
            g.Mensaje("Herramienta Guardada", "¡Atencion!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = AH.Mostrar(filtro).Tables["Herramientas"];
            if (pu == "Gerente")
            {
                tabla.Columns.Insert(5, g.Boton("Editar", Color.Blue));
                tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red));
            }
            if (pu == "Encargado")
            {
                tabla.Columns.Insert(5, g.Boton("Editar", Color.Blue));
            }
            if (pu == "Obrero")
            {
                
            }
        }
    }
}
