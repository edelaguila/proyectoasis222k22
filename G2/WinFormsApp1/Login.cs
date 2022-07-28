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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contraseña, cargo = " ";
            int columna = 3;
            string[] resultado = new string[columna];
            usuario = txtusuario.Text;
            contraseña = txtcontraseña.Text;
            
            if(radioadministrador.Checked== true)
            {
                cargo = "administrador";
            }

            if (radiotrabajador.Checked == true)
            {
                cargo = "trabajador";
            }


            conexion con = new conexion();
            string sql = "select * from usuario where usuario = '"+ usuario +"'";

            resultado = con.buscar(sql, columna);

            if(resultado[0].Equals(usuario) && resultado[1].Equals(contraseña)&& resultado[2].Equals(cargo))
            {

                // Menu m = new Menu();
                // m.Show();

                //solo es para prueba
                Paciente p = new Paciente();
                p.Show();

                //
                this.Hide();
                MessageBox.Show("Bienvenido " + usuario);
            }
            else 
            { MessageBox.Show("Datos Incorrectos"); }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = !checkver.Checked;
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            
        
        }
    }
}
