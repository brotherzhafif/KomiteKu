using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomiteKu
{
    internal class Forms
    {
        // Form Initiation
        public static Navigation navigation = new Navigation();
        public static Home home = new Home();

        // Call the initiated forms idk
        public static void Show(Form form)
        {
            form.MdiParent = home;
            form.Show();
        }
    }
}
