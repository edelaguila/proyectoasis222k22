using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void checkver_CheckedChanged(object sender, EventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = !checkver.Checked;
        }

        private void checkver2_CheckedChanged(object sender, EventArgs e)
        {
            txtconfirmar.UseSystemPasswordChar = !checkver.Checked;
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string usuario, contraseña, cargo = " ";
            int columna = 4;
            string[] resultado = new string[columna];
            usuario = txtusuario.Text;
            contraseña = txtcontraseña.Text;

            if (radioadministrador.Checked == true)
            {
                cargo = "administrador";
            }

            if (radiotrabajador.Checked == true)
            {
                cargo = "trabajador";
            }

           
            string sql = "insert into usuario values '" + usuario + "'" +contraseña+"'" +cargo +"'";
        }
    }
}
