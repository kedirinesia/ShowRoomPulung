using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoomPulung
{
    internal class conn
    {
        public static SqlConnection Getconn()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ShowRoomPulung;Integrated Security=True;Encrypt=False; ");
            return conn;    
        }

        public static SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ShowRoomPulung;Integrated Security=True;Encrypt=False; ");
        public static SqlCommand cmd = new SqlCommand("", con);




        public static Object getQuery(string query) {
        
            DataTable dt = new DataTable();
            con.Open();
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);    
            con.Close();
            return dt;

        }

        public static void exQuery(string query)
        {
            con.Open(); 
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close() ;

        }





    }


}
