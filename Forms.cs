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
        public static Siswa siswa = new Siswa();
        public static Ruangan ruangan = new Ruangan();

        // Call The Initiated Form Object
        public static void Show(string form, Form parent)
        {
            Forms.navigation.MdiParent = parent;
            Forms.siswa.MdiParent = parent;
            Forms.ruangan.MdiParent = parent;

            if (form == "navigation") Forms.navigation.Show();
            if (form == "siswa") Forms.siswa.Show();
            if (form == "ruangan") Forms.ruangan.Show();

        }
    }
}
