using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using conexionbd;

namespace facturacion
{
    public class productos
    {
        public DataTable Mostrar()
        {
            string sql;
            DataTable dt = new DataTable();
            conexionbd.datos consulta = new conexionbd.datos();
            sql = "SELECT * from USO_LIBRE_NVO";
            dt = consulta.tabla(sql);
            return dt;
        }

        public void insertar(int id,string user, string password)
        {
            string sql;
            sql = "INSERT INTO loggin ";
            sql = sql + " (ID,USR, PASS) ";
            sql = sql + " VALUES ";
            sql = sql + " (" + id + ",'" + user + "','"+password+"')";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }
    }
}
