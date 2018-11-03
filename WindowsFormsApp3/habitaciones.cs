using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using administracion;





namespace WindowsFormsApp3
{
    public partial class habitaciones : Form
    {
        public habitaciones()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loadgrilla();
        }

        private void Loadgrilla()
        {
            DataTable dt = new DataTable();
            administracion.personas datos = new administracion.personas();
            dt = datos.Mostrar();
            dataGridView1.DataSource = dt;
        }

    }
}
