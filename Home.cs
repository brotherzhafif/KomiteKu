using System;

using System.Windows.Forms;

namespace KomiteKu
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }
        private void Home_Load(object sender, EventArgs e)
        {
            tampilkan(Forms.Nav_form);
        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        void tampilkan(Form form)
        {
            form.Hide();
            form.MdiParent = this;
            form.Show();
        }
    }
}
