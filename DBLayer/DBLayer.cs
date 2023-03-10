using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataBaseLayer
{
    public class DBLayer
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        public DataTable GetAllDataFromArlyText()
        {
            try
            {
                DataTable text = new DataTable(); conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM ArlyText", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                text.Load(reader);
                conn.Close(); 
                return text;
            }
            catch (ArgumentOutOfRangeException) { return null; }
        }
        public void EditTextOnButton(string txt)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE ArlyText SET text = @txt", conn); 
                cmd.Parameters.AddWithValue("txt", txt); 
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception) { }
        }
    }
}
