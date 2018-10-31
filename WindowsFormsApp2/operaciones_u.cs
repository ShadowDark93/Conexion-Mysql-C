using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using conexionbd;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class operaciones_u
    {

        public void agregar_persona(int cedula, string nombre, string apellido, char genero, string fecha_nacimiento) {
            string sql;
            sql = "INSERT INTO persona (ID_PERSONA, TIPO_ID, NOMBRE_PERSONA, APELLIDO_PERSONA, GENERO, FECHA_NACIMIENTO) ";
            sql = sql + " VALUES ('" + cedula + "','1','" + nombre + "','" + apellido + "','" + genero + "','" + fecha_nacimiento + "')";
        conexionbd.datos consulta = new conexionbd.datos();
            consulta.Ejecutar(sql);
        }

        public void agregar_usuario(String nombre_usuario,  int cedula, String correo, String contraseña){
         String sql;
         sql = "INSERT INTO PERSONA";
            
         }

        internal void agregar_persona(string text1, string text2, TextBox txtApellidos, string text3, string text4)
        {
            throw new NotImplementedException();
        }
    }
}
