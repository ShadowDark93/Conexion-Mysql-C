using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using conexionbd;


namespace administracion
{
    class operaciones_motel
    {
        public void agregarmotel(string nombre, int nit, string direccion)
        {
            string sql;
            sql = "INSERT INTO motel (ID_MOTEL, NOMBRE_MOTEL, DIRECCION_MOTEL) ";
            sql = sql + " VALUES ('" + nit + "','" + nombre + "','" + direccion + "')";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }
        public void actualizar_motel(string nombre, int nit, string direccion)
        {
            String sql;
            sql = "UPDATE motel SET NOMBRE_MOTEL = '" + nombre + "',DIRECCION_MOTEL='" + direccion + "',IDMOTEL='" + nit;
            sql = sql + "WHERE ID_MOTEL= '" + nit + "'";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }
        public void eliminar_motel(int nit)
        {
            String sql;
            sql = "DELETE FROM motel WHERE ID_MOTEL = '" + nit + "' ";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }
        public DataTable Consultar_motel(int nit)
        {
            String sql;
            DataTable dr;
            conexionbd.datos consulta = new conexionbd.datos();
            sql = "SELECT * FROM motel WHERE ID_MOTEL= '" + nit + "' ";
            dr = consulta.tabla(sql);
            return dr;
        }
        public DataTable Consultar_motel()
        {
            String sql;
            DataTable dt = new DataTable();
            conexionbd.datos consulta = new conexionbd.datos();
            sql = "SELECT * FROM motel ";
            dt = consulta.tabla(sql);
            return dt;
        }

        public void agregar_habitacion(int idHabitacion, int idTipoHabitacion, int idMotel, char cantidadHabitacion)
        {
            string sql;
            sql = "INSERT habitacion (ID_HABITACION, ID_TIPO_HABITACION, ID_MOTEL, CANTIDAD_HABITACION) ";
            sql = sql + "VALUES ('" + idHabitacion + "','" + idTipoHabitacion + "','" + idMotel + "','" + cantidadHabitacion + "')";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }

        
    }   
    
}
