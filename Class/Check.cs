using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomiteKu.Class
{
    internal class Check
    {
        public static Regex text = new Regex("[a-zA-Z ]");
        public static Regex number = new Regex("[0-9.,]");

        public static bool Errors(string[] input, Regex regex)
        {
            bool valid = true;
            for (int i = 0; i < input.Length; i++)
            {
                // Check Empty Input
                if (string.IsNullOrEmpty(input[i]))
                {
                    MessageBox.Show("Tolong Isi Seluruh Kolom");
                    valid = false;
                    break;
                }

                // Check Valid Expression
                bool result = regex.IsMatch(input[i]);
                if (result == false)
                {
                    MessageBox.Show("Tolong Masukan Input Yang Valid");
                    valid = false;
                    break;
                }
            }
            if (valid)
            {
                MessageBox.Show("Bruakakakak");
                return true;
            }
            return false;
        }
    }
}
