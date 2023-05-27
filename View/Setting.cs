using System.Collections.Specialized;
using System;
using System.Configuration;
using System.Windows.Forms;
using KomiteKu.Class;
using KomiteKu.Controller;

namespace KomiteKu
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            FillInput();
        }

        // Config Handler Start
        public void FillInput()
        {
            TextBox[] input = { txt_semester0, txt_semester1, txt_semester2, txt_semester3, txt_semester4, txt_semester5 };
            try
            {
                // Display The Setting To The Textbox
                for (int i = 0; i < input.Length; i++)
                {
                    input[i].Text = Execute.Select(Data.SqlSelectNonimal).Rows[0][i].ToString();
                }
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[ReadAppSettings: {0}]", e.ToString());
            }
        }
        public void UpdateConfig(object sender, EventArgs e)
        {
            // Check If The Input Was Valid
            string[] input = { txt_semester0.Text, txt_semester1.Text, txt_semester2.Text, txt_semester3.Text, txt_semester4.Text, txt_semester5.Text };

            if (Check.InputErrors(input, Check.number) == true)
            {
                Execute.Record(Data.SqlUpdateNominal, input);
            }
            FillInput();
        }
    }
}
