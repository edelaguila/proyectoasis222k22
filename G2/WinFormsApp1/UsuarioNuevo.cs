using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace LaboratorioClinico
{
    public partial class UsuarioNuevo : Form
    {
        public UsuarioNuevo()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string usuario, contraseña,confirmar, cargo = " ";
            int columna = 3;
            string[] resultado = new string[columna];
            
            usuario = txtusuario.Text;
            contraseña = txtcontraseña.Text;
            confirmar = txtconfirmar.Text;

            if (radioadministrador.Checked == true)
            {
                cargo = "administrador";
            }

            if (radiotrabajador.Checked == true)
            {
                cargo = "trabajador";
            }

            conexion con = new conexion();
            
            if (cargo == "administrador")
            {
                string validacion="4cept0", prueba;
                prueba = Interaction.InputBox("Ingrese la contraseña para crear el usuario");

                if (prueba.Equals(validacion))
                {
                    if (confirmar.Equals(contraseña) && cargo != " ")
                    {
                        string sql = "select * from usuario where usuario =  '" + usuario + "'";
                        resultado = con.buscar(sql, 3);

                        if (resultado[0] == null)
                        {
                            string sql1 = "insert into usuario values ('" + usuario + "', '" + contraseña + "','" + cargo + "')";
                            con.IDU(sql1);
                            Login l = new Login();
                            l.Show();
                            this.Hide();

                        }

                        else if (resultado[0].Equals(usuario))
                        {
                            txtusuario.Clear();
                            txtcontraseña.Clear();
                            txtconfirmar.Clear();
                            radioadministrador.Checked = false;
                            radiotrabajador.Checked = false;
                            MessageBox.Show("El usuario ya existe");
                        }

                    }
                    else
                    {
                        txtcontraseña.Clear();
                        txtconfirmar.Clear();
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }
                else
                {
                    MessageBox.Show("No tiene permisos");
                }
               
            }

            else
            {
                if (confirmar.Equals(contraseña) && cargo != " ")
                {
                    string sql = "select * from usuario where usuario =  '" + usuario + "'";
                    resultado = con.buscar(sql, 3);

                    if (resultado[0] == null)
                    {
                        string sql1 = "insert into usuario values ('" + usuario + "', '" + contraseña + "','" + cargo + "')";
                        con.IDU(sql1);
                        Login l = new Login();
                        l.Show();
                        this.Hide();

                    }

                    else if (resultado[0].Equals(usuario))
                    {
                        txtusuario.Clear();
                        txtcontraseña.Clear();
                        txtconfirmar.Clear();
                        radioadministrador.Checked = false;
                        radiotrabajador.Checked = false;
                        MessageBox.Show("El usuario ya existe");
                    }

                }
                else
                {
                    txtcontraseña.Clear();
                    txtconfirmar.Clear();
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
           

            

        }

        private void checkver_CheckedChanged(object sender, EventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = !checkver.Checked;
        }

        private void checkver2_CheckedChanged(object sender, EventArgs e)
        {
            txtconfirmar.UseSystemPasswordChar = !checkver2.Checked;
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

        private void btnregresar_MouseHover(object sender, EventArgs e)
        {
            btnregresar.BackColor = Color.FromArgb(255, 255, 255);
            btnregresar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btnregresar_MouseLeave(object sender, EventArgs e)
        {
            btnregresar.BackColor = Color.FromArgb(49, 101, 244);
            btnregresar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();

        }
    }
}
