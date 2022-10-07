using System.Data;
using EntidadPermisos;

namespace AccesoDatosPermisos
{
    interface IEntidades
    {
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        DataSet Mostrar(string filtro);
    }
}
