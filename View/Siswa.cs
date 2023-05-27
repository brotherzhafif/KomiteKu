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
        }
        private void Action(object sender, EventArgs e)
        {
            var status = btn_submit.Text.ToLower();
            MessageBox.Show(status);

            string[] textbox = { txt_nis.Text, txt_nama.Text };
            Check.Errors(textbox, Check.text);
        }
        
    }
}
