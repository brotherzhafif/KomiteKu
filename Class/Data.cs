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

        // Tabel Siswa SQL Code Start
        public static string SqlSelectAllSiswa = "SELECT * FROM Siswa";
        public static string SqlSelectOneSiswa = "SELECT * FROM Siswa WHERE nis=@input0";
        public static string SqlDeleteSiswa = "DELETE FROM Siswa WHERE nis=@input0";
        public static string SqlInsertSiswa = "INSERT INTO Siswa (nis, nama, kelas) VALUES (@input0, @input1, @input2)";
        public static string SqlUpdateSiswa = "UPDATE Siswa SET nama=@input1, kelas=@input2 WHERE nis=@input0";
    }
}
