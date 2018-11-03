using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using conexionbd;

namespace WindowsFormsApp3
{
    class operaciones_habitacion
    {

        public void agregar_habitacion(int idHabitacion, int idTipoHabitacion, int idMotel, char cantidadHabitacion ){

            string sql;
            sql = "INSERT habitacion (ID_HABITACION, ID_TIPO_HABITACION, ID_MOTEL, CANTIDAD_HABITACION) ";
            sql=sql+"VALUES ('"+idHabitacion+"','"+idTipoHabitacion+"','"+idMotel+"','"+cantidadHabitacion+"')";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }

        public void actualiza_habitacion(int idHabitacion, int idTipoHabitacion, int idMotel, char cantidadHabitacion)
        {
            string sql;
            sql = "UPDATE habitacion SET ID_HABITACION ='"+idTipoHabitacion+ "', ID_MOTEL ='"+idMotel+ "', CANTIDAD_HABITACION ='"+cantidadHabitacion+"'";
            sql = sql + "WHERE ID_HABITACION='" + idHabitacion + "'";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }

        public void eliminar_habitacion(int idHabitacion){
            string sql;
            sql = "DELETE FROM habitacion WHERE ID_HABITACION ='"+idHabitacion+"'";
            conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }

        public DataTable consultar_habitacion(int idHabitacion)
        {
            string sql;
            DataTable dr;
            conexionbd.datos consulta = new conexionbd.datos();
            sql = "SELECT * FROM MOTEL WHERE ID_HABITACION ='"+idHabitacion+"'";
            dr = consulta.tabla(sql);
            return dr;
        }

        public DataTable consultar_habitacion(){
            string sql;
            DataTable dt;
            conexionbd.datos consulta = new conexionbd.datos();
            sql = "SELECT * FROM habitaciones";
            dt = consulta.tabla(sql);
            return dt;
        }
    }
}
