using System;
using AccesoDatosPermisos;
using System.Windows.Forms;
using System.Data;

namespace ManejadorPermisos
{
    public class ManejadorSesion
    {
        AccesoLogin AL = new AccesoLogin();
        public static string nombre = "", puesto = "", modulo = "";
        public string Validar(TextBox te1, TextBox te2)
        {
            string rs = "";
            DataSet data = AL.Validar(te1.Text, te2.Text).Tables["Login"].DataSet;
            try
            {
                nombre = data.Tables[0].Rows[0]["Usuario"].ToString();
                puesto = data.Tables[0].Rows[0]["Puesto"].ToString();
                modulo = data.Tables[0].Rows[0]["Modulo"].ToString();
                rs = "SI";
            }
            catch (Exception)
            {
                rs = "NO";
            }
            return rs;
        }
    }
}
