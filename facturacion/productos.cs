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
            sql = "SELECT idempleado,docmnt_empld from empleados";
            dt = consulta.tabla(sql);
            return dt;
        }

        public void insertar(double id,string documento)
        {
            string sql;
            sql = "INSERT INTO empleados ";
            sql = sql + " (idempleado,docmnt_empld) ";
            sql = sql + " VALUES ";
            sql = sql + " (" + id + ",'" + documento + "')";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }
    }
}
