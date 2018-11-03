using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using conexionbd;

namespace administracion
{
    class operaciones_persona
    {
        public void agregar_persona(int cedula, string nombre, string apellido, char genero, string fecha_nacimiento)
        {
            string sql;
            sql = "INSERT INTO persona (ID_PERSONA, TIPO_ID, NOMBRE_PERSONA, APELLIDO_PERSONA, GENERO, FECHA_NACIMIENTO) ";
            sql = sql + " VALUES ('" + cedula + "','1','" + nombre + "','" + apellido + "','" + genero + "','" + fecha_nacimiento + "')";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }
        public void actualizar_persona(int cedula, string nombre, string apellido, char genero, string fecha_nacimiento)
        {
            String sql;
            sql = "UPDATE persona SET NOMBRE_PERSONA  = '" + nombre + "',APELLIDO_PERSONA = '" + apellido + "',GENERO'" + genero + "',FECHA_NACIMIENTO'" + fecha_nacimiento + "'";
            sql = sql + "WHERE ID_PERSONA = '" + cedula + "'";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }

        public void elminar_persona(int cedula)
        {
            String sql;
            sql = "DELETE FROM persona WHERE ID_PERSONA = '" + cedula + "'";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }

        public DataTable consultar_persona(int cedula)
        {
            String sql;
            DataTable dr;
            conexionbd.datos consulta = new conexionbd.datos();
            sql = "SELECT * FROM persona WHERE ID_PERSONA = '" + cedula + "'";
            dr = consulta.tabla(sql);
            return dr;
            // hay que preguntar lo de consulta.tabala registro
        }

        public DataTable consultar_persona()
        {
            String sql;
            DataTable dt = new DataTable();
            conexionbd.datos consulta = new conexionbd.datos();
            sql = "SELECT * FROM persona ";
            dt = consulta.tabla(sql);
            return dt;
        }
    }
}
