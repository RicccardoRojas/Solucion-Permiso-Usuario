using System;
using System.Data;
using ConectarBD;
using EntidadPermisos;

namespace AccesoDatosPermisos
{
    public class AccesoUsuarios : IEntidades
    {
        Base b = new Base("localhost","root","","permisos");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteusuario({0})",Entidad.IDUsuario));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertusuarios('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7})",Entidad.Nombre,
                Entidad.ApellidoP, Entidad.ApellidoM, Entidad.FechaNacimiento, Entidad.RFC, Entidad.Modulo, Entidad.Puesto,
                Entidad.IDUsuario));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showusuarios('%{0}%')",filtro),"Usuarios");
        }

        public DataSet Mostrar2()
        {
            return b.Obtener("call showusuarios2()", "Usuarios");
        }
    }
}
