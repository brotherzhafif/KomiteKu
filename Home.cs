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
            Forms.Show(Forms.navigation);
            
            // Set the size to be fixed
            MinimumSize = this.Size;
            MaximumSize = this.Size;
        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Show(Forms.navigation);
        }

        
    }
}
