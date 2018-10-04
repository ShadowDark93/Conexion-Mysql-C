using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.OracleClient;


namespace conexionbd
{
    public class datos
    {
        private string conexionbd = ConfigurationManager.ConnectionStrings["conexion"].ToString();

        public DataTable tabla(string strsql)
        {
            
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = conexionbd;
           MySqlCommand comm = new MySqlCommand();
            comm.Connection = conn;
            comm.CommandText = strsql;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
           MySqlDataAdapter da = new MySqlDataAdapter(comm);
            Int64 i;
            i = da.Fill(dt);
            dt1 = dt.Copy();
            dt.Clear();
            conn.Close();
            conn = null;
            if (dt1.Rows.Count <= 0)
            {
                dt1 = null;
            }

            return dt1;

        }

        public DataRow registro(string strsql)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = conexionbd;
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = conn;
            comm.CommandText = strsql;
            DataTable dt = new DataTable();
            DataRow dr;
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            Int64 i;
            i = da.Fill(dt);
            dt1 = dt.Copy();
            dt.Clear();
            conn.Close();
            conn = null;
            if (dt1.Rows.Count > 0)
            {
                dr = dt1.Rows[0];

            }
            else
            {
                dr = null;
            }

            return dr;

        }

        public Boolean valida(string strsql)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = conexionbd;
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = conn;
            comm.CommandText = strsql;
            DataTable dt = new DataTable();
            Boolean var;
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            Int64 i;
            i = da.Fill(dt);
            dt1 = dt.Copy();
            dt.Clear();
            conn.Close();
            conn = null;
            if (dt1.Rows.Count > 0)
            {
                var = true;
            }
            else
            {
                var = false;
            }

            return var;

        }

        public void Ejecutar(string strsql)
        {

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = conexionbd;
            conn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = strsql;
            Int64 i;
            i = comm.ExecuteNonQuery();
            conn.Close();

        }

        public object Scalar(string strsql)
        {

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = conexionbd;
            conn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = strsql;
            object s;

            s = comm.ExecuteScalar();
            conn.Close();

            return s;

        }

    }
}
