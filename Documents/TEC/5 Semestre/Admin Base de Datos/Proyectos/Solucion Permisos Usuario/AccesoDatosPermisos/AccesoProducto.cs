using System;
using System.Data;
using ConectarBD;
using EntidadPermisos;

namespace AccesoDatosPermisos
{
    public class AccesoProducto:IEntidades
    {
        Base b = new Base("localhost","root","","permisos");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteproducto({0})",Entidad.CodigoBarras));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertproducto({0},'{1}','{2}','{3}')",Entidad.CodigoBarras, Entidad.Nombre,
                Entidad.Descripcion, Entidad.Marca));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showproducto('%{0}%')",filtro),"Producto");
        }
    }
}
