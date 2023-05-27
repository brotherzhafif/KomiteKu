using KomiteKu.Class;
using KomiteKu.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomiteKu
{
    public partial class Siswa: Form
    {
        public Siswa()
        {
            InitializeComponent();
            DGV_Siswa.DataSource = Execute.Select(Data.SqlSelectAllSiswa);
            cbox_kelas.DataSource = Execute.Select(Data.SQLSelectAllRuangan);
            cbox_kelas.ValueMember = "kelas";
            cbox_kelas.DisplayMember = "kelas";
        }

        private void Action(object sender, EventArgs e)
        {
            string[] inputs = { txt_nis.Text, txt_nama.Text, cbox_kelas.Text };
            if (Check.InputErrors(inputs, Check.special) == true)
            {
                if (Check.Decision(sender) == "hapus") Execute.Record(Data.SqlDeleteSiswa, inputs);
                if (Check.Decision(sender) == "tambah") Execute.Record(Data.SqlInsertSiswa, inputs);
                if (Check.Decision(sender) == "edit") Execute.Record(Data.SqlUpdateSiswa, inputs);
            }
            DGV_Siswa.DataSource = Execute.Select(Data.SqlSelectAllSiswa);
        }
    }
}
