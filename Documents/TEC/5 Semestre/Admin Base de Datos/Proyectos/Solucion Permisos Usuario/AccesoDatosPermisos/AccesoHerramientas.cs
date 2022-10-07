using System;
using System.Data;
using ConectarBD;
using EntidadPermisos;

namespace AccesoDatosPermisos
{
    public class AccesoHerramientas : IEntidades
    {
        Base b = new Base("localhost","root","","permisos");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteherramientas({0})",Entidad.CodigoHerramienta));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertherramientas('{0}',{1},'{2}','{3}',{4})",Entidad.Nombre, Entidad.Medida,
                Entidad.Marca, Entidad.Descripcion, Entidad.CodigoHerramienta));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showherramientas('%{0}%')",filtro),"Herramientas");
        }
    }
}
