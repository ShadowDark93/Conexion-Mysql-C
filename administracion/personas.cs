using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace administracion
{
   public class personas
    {

        private int id;

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }

        private string nombres;

        public DataTable Mostrar()
        {
            string sql;
            DataTable dt = new DataTable();
            conexionbd.datos consulta = new conexionbd.datos();
            sql = "SELECT * from persona";
            dt = consulta.tabla(sql);
            return dt;
        }

    }
}
