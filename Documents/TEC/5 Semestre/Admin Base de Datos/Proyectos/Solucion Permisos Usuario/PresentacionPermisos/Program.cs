using System;
using System.Windows.Forms;

namespace PresentacionPermisos
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new FrmLogin());
        }
    }
}
