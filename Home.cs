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

        // Event Listener Start

        private void Home_Load(object sender, EventArgs e)
        {
            Navigate("navigation", e);
            
            // Adding Some Form Setting
            MinimumSize = this.Size;
            MaximumSize = this.Size;
        }

        public void Navigate(object sender, EventArgs e)
        {
            string name = sender.ToString().ToLower();
            Forms.Show(name, this);
        }
    }
}
