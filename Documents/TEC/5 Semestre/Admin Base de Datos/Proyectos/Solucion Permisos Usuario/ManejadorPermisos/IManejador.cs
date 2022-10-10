using System.Windows.Forms;
using EntidadPermisos;

namespace ManejadorPermisos
{
    interface IManejador
    {
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        void Mostrar(DataGridView tabla, string filtro);
    }
}
