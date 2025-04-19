using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHopDong
{
    internal class DAO
    {
        public static string ConnectionString = "Data Source = HUYLE;" +
                                                "Initial Catalog=QLHD;Integrated Security=True";

        public static SqlConnection con;
        public static DataTable LoadDataToTable(string sql)
        {
            Connect();
            using (var da = new SqlDataAdapter(sql, con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void Connect()
        {
            if (con == null)
                con = new SqlConnection(ConnectionString);

            if (con.State != ConnectionState.Open)
                con.Open();
        }

        public static void Close()
        {
            if (con != null && con.State == ConnectionState.Open)
                con.Close();
        }

        public static string getSQLdateFromText(string dateDDMMYYYY)
        {
            string[] elemets = dateDDMMYYYY.Split('/');
            return elemets[2] + '/' + elemets[1] + '/' + elemets[0];
        }
    }
}
