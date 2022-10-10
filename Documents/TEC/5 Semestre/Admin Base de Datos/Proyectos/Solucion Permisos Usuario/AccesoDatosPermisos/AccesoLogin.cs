using System;
using System.Data;
using ConectarBD;
using EntidadPermisos;

namespace AccesoDatosPermisos
{
    public class AccesoLogin : IEntidades
    {
        Base b = new Base("localhost","root","","permisos");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deletelogin({0})",Entidad.IDLogin));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertlogin({0},'{1}',{2})",Entidad.FKIDUsuario, Entidad.Contraseña,
                Entidad.IDLogin));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showlogin('%{0}%')",filtro),"Login");
        }

        public DataSet Validar(string text1, string text2)
        {
            return b.Obtener(string.Format("call validar('{0}','{1}')",text1,text2),"Login");
        }
    }
}
