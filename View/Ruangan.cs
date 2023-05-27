using KomiteKu.Class;
using KomiteKu.Controller;
using System;
using System.Windows.Forms;

namespace KomiteKu
{
    public partial class Ruangan : Form
    {
        public Ruangan()
        {
            InitializeComponent();
            DGV_Ruangan.DataSource = Execute.Select(Data.SQLSelectAllRuangan);
        }
        private void Action(object sender, EventArgs e)
        {     
            string[] inputs = { txt_kelas.Text };
            if (Check.InputErrors(inputs, Check.text) == true)
            {
                if (Check.Decision(sender) == "hapus") Execute.Record(Data.SqlDeleteRuangan, inputs); 
                if (Check.Decision(sender) == "tambah") Execute.Record(Data.SqlInsertRuangan, inputs);
            }
            DGV_Ruangan.DataSource = Execute.Select(Data.SQLSelectAllRuangan);
        }
    }
}
