using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioClinico
{
    public partial class Recuperar : Form
    {
        public Recuperar()
        {
            InitializeComponent();
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            string correo, contraseña, nueva;

            correo = txtcorreo.Text;
            contraseña = txtcontraseña.Text;
            nueva = txtnueva.Text;
            string[] usuario = new string[1];
            conexion con = new conexion();

            if (contraseña.Equals(nueva))
            {
                string sql1 = "select usuario from empleado where correo = '"+ correo+"'";
                usuario = con.buscar(sql1, 1);
                string sql = "update usuario set contraseña = '" + nueva + "' where usuario = '"+ usuario[0] +"'";
                con.IDU(sql);
                Login l = new Login();
                this.Hide();
                l.Show();
            }

            else
            {
                MessageBox.Show("Datos incorrectos");
            }




        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void checkver_CheckedChanged(object sender, EventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = !checkver.Checked;
        }

        private void checkver2_CheckedChanged(object sender, EventArgs e)
        {
            txtnueva.UseSystemPasswordChar = !checkver.Checked;
        }
    }
}
