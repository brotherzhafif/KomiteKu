using KomiteKu.Class;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KomiteKu.Controller
{
    internal class Execute : Data
    {
        public static void Record(string sql, string[] input)
        {
            SqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                for (int i = 0; i < input.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@input"+i.ToString(), input[i]);
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Proses Berhasil");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close(); 
        }

        public static DataTable Select(string sql)
        {
            DataTable dt = new DataTable();

            dt.Reset();
            dt = new DataTable();

            SqlCommand cmd = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            connection.Close();
            return dt;
        }


    }
}
