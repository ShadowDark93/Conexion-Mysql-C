using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using facturacion;

namespace proyecto_ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
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
            facturacion.productos datos = new facturacion.productos();
            dt = datos.Mostrar();
            dtgempleados.DataSource = dt;
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            facturacion.productos datos = new facturacion.productos();
            datos.insertar(Convert.ToInt32(txtid.Text), txtUsuario.Text, txtPass.Text);
            Loadgrilla();
            limpiacampos();
            MessageBox.Show("Se grabó con exito");
        }
        private void limpiacampos()
        {
            txtUsuario.Text = "";
            txtid.Text = "";
            txtid.Focus();
        }
    }
}
