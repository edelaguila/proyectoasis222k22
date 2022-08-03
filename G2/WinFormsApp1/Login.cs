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



                if(resultado[2].Equals("administrador"))
                {
                    Menu m = new Menu();
                    m.Show();
                    this.Hide();
                    MessageBox.Show("Bienvenido " + usuario);
                    string sql2 = "insert into bitacora (usuario, fecha, hora_inicio) values ('" + usuario + "','" + DateTime.Now.Date.ToString("yyyyMMdd") + "','" + DateTime.Now.ToString("hh:mm:ss") + "')";
                    con.IDU(sql2);
                }
                else if (resultado[2].Equals("trabajador"))
                {
                    MenuTrabajador m = new MenuTrabajador();
                    m.Show();
                    this.Hide();
                    MessageBox.Show("Bienvenido " + usuario);
                    string sql2 = "insert into bitacora (usuario, fecha, hora_inicio) values ('"+usuario+"','"+DateTime.Now.Date.ToString("yyyyMMdd") +"','"+DateTime.Now.ToString("hh:mm:ss") +"')";
                    con.IDU(sql2);
                }
                else
                {
                    MessageBox.Show("Error");
                }
                 
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
            UsuarioNuevo cu = new UsuarioNuevo();
            cu.Show();
            this.Hide();
        
        }

        private void btningresar_MouseHover(object sender, EventArgs e)
        {
            btningresar.BackColor = Color.FromArgb(255, 255, 255);
            btningresar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btningresar_MouseLeave(object sender, EventArgs e)
        {
            btningresar.BackColor = Color.FromArgb(49, 101, 244);
            btningresar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btncrear_MouseHover(object sender, EventArgs e)
        {
            btncrear.BackColor = Color.FromArgb(255, 255, 255);
            btncrear.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btncrear_MouseLeave(object sender, EventArgs e)
        {
            btncrear.BackColor = Color.FromArgb(49, 101, 244);
            btncrear.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void lbolvido_Click(object sender, EventArgs e)
        {

            if(txtusuario.Text.Length == 0)
            {
                MessageBox.Show("Introduzca un usuario");
                txtusuario.Focus();
            }
            else
            {
                string sql = "select * from empleado where usuario = '" + txtusuario.Text + "'";

                string[] empleado = new string[7];
                conexion con = new conexion();
                empleado = con.buscar(sql, 7);


                if(empleado[1] == null)
                {
                    MessageBox.Show("No hay ningun registro con ese usuario");
                }
                else
                {
                    Recuperar re = new Recuperar();
                    this.Hide();
                    re.Show();
                    
                }
                
            }

            
        }
    }
}
