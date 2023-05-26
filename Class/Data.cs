using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomiteKu.Class
{
    internal class Data
    {
        public static SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Data\\db.mdf\";Integrated Security=True");
        public static string SQL_InsertSiswa;
    }
}
