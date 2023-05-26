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
        // Form Objects Initiation
        public static Home home = new Home();
        public static Siswa siswa = new Siswa();
        public static Ruangan ruangan = new Ruangan();
        public static Navigation navigation = new Navigation();
        public static StatusPembayaran statusPembayaran = new StatusPembayaran();
        public static TambahPembayaran tambahPembayaran = new TambahPembayaran();

        // Call And Show The Initiated Form Object
        public static void Show(string form, Form parent)
        {
            Forms.navigation.MdiParent = parent;
            Forms.siswa.MdiParent = parent;
            Forms.ruangan.MdiParent = parent;
            Forms.statusPembayaran.MdiParent = parent;
            Forms.tambahPembayaran.MdiParent = parent;

            if (form == "siswa") Forms.siswa.Show();
            if (form == "ruangan") Forms.ruangan.Show();
            if (form == "navigation") Forms.navigation.Show();
            if (form == "pembayaran") Forms.statusPembayaran.Show();
            if (form == "tambah pembayaran") Forms.tambahPembayaran.Show();


        }
    }
}
