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
        // Declare Some Regex
        public static Regex text = new Regex("[a-zA-Z ]");
        public static Regex number = new Regex("[0-9.,]");
        public static Regex special = new Regex("[0-9a-zA-Z ]");

        // Validating Every Inputs 
        public static bool InputErrors(string[] input, Regex regex)
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

        // Check Decide Which Action Will Execute Next
        public static string Decision(object sender)
        {
            if (sender.ToString().ToLower().Contains("hapus")) return "hapus";
            if (sender.ToString().ToLower().Contains("tambah")) return "tambah";
            if (sender.ToString().ToLower().Contains("edit")) return "edit";

            return "";
        }
    }
}
