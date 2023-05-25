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

        // Call The Initiated Form Object
        void Show(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        // Event Listener Start

        private void Home_Load(object sender, EventArgs e)
        {
            Show(Forms.navigation);
            
            // Adding Some Form Setting

            MinimumSize = this.Size;
            MaximumSize = this.Size;

            
        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show(Forms.navigation);
        }

        private void dataSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show(Forms.siswa);
        }
    }
}
