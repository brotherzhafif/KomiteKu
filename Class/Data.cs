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
        // Connection Initiation
        public static SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Data\\db.mdf\";Integrated Security=True");

        // SQL Code For Each Execution
        // Tabel Ruangan SQL Code Start
        public static string SqlInsertRuangan = "INSERT INTO Ruangan (kelas) VALUES (@input0)";
        public static string SqlDeleteRuangan = "DELETE FROM Ruangan WHERE kelas=@input0";
        public static string SQLSelectAllRuangan = "SELECT * FROM Ruangan";

    }
}
