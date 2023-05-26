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
            // Display Some Default View Forms
            Navigate("navigation", e);
            Navigate("pembayaran", e);

            // Adding Some Form Setting
            MinimumSize = this.Size;
            MaximumSize = this.Size;
        }

        // Show Or Navigate To Another Forms
        private void Navigate(object sender, EventArgs e)
        {
            string name = sender.ToString().ToLower();
            Forms.Show(name, this);
        }
    }
}
