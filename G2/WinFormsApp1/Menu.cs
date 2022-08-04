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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void picturecliente_Click(object sender, EventArgs e)
        {
            Paciente pa = new Paciente();
            pa.Show();
            this.Hide();
        }

        private void picturecliente_MouseHover(object sender, EventArgs e)
        {
            picturecliente.BackColor = Color.FromArgb(255, 255, 255);
            lbcliente.BackColor = Color.FromArgb(255, 255, 255);
            lbcliente.ForeColor = Color.FromArgb(49, 101, 244);
            picturecliente.Size = new System.Drawing.Size(139, 119);
            lbcliente.Location = new Point(111, 205);

        }

        private void picturecliente_MouseLeave(object sender, EventArgs e)
        {
            picturecliente.BackColor = Color.FromArgb(49, 101, 244);
            lbcliente.ForeColor = Color.FromArgb(255, 255, 255);
            lbcliente.BackColor = Color.FromArgb(49, 101, 244);
            picturecliente.Size = new System.Drawing.Size(129, 109);
            lbcliente.Location = new Point(105, 196);
        }

        private void lbtrabajador_MouseHover(object sender, EventArgs e)
        {
            picturetrabajador.BackColor = Color.FromArgb(255, 255, 255);
            lbtrabajador.BackColor = Color.FromArgb(255, 255, 255);
            lbtrabajador.ForeColor = Color.FromArgb(49, 101, 244);
            picturetrabajador.Size = new System.Drawing.Size(139, 119);
            lbtrabajador.Location = new Point(375, 205);
        }

        private void lbtrabajador_MouseLeave(object sender, EventArgs e)
        {
            picturetrabajador.BackColor = Color.FromArgb(49, 101, 244);
            lbtrabajador.ForeColor = Color.FromArgb(255, 255, 255);
            lbtrabajador.BackColor = Color.FromArgb(49, 101, 244);
            picturetrabajador.Size = new System.Drawing.Size(129, 109);
            lbtrabajador.Location = new Point(368, 196);
        }

        private void lblaboratorio_MouseHover(object sender, EventArgs e)
        {
            picturelaboratorio.BackColor = Color.FromArgb(255, 255, 255);
            lblaboratorio.BackColor = Color.FromArgb(255, 255, 255);
            lblaboratorio.ForeColor = Color.FromArgb(49, 101, 244);
            picturelaboratorio.Size = new System.Drawing.Size(139, 119);
            lblaboratorio.Location = new Point(649, 205);
        }

        private void picturelaboratorio_MouseLeave(object sender, EventArgs e)
        {
            picturelaboratorio.BackColor = Color.FromArgb(49, 101, 244);
            lblaboratorio.ForeColor = Color.FromArgb(255, 255, 255);
            lblaboratorio.BackColor = Color.FromArgb(49, 101, 244);
            picturelaboratorio.Size = new System.Drawing.Size(129, 109);
            lblaboratorio.Location = new Point(643, 196);
        }

        private void picturecita_MouseHover(object sender, EventArgs e)
        {
            picturecita.BackColor = Color.FromArgb(255, 255, 255);
            lbcita.BackColor = Color.FromArgb(255, 255, 255);
            lbcita.ForeColor = Color.FromArgb(49, 101, 244);
            picturecita.Size = new System.Drawing.Size(139, 119);
            lbcita.Location = new Point(129, 412);
        }

        private void picturecita_MouseLeave(object sender, EventArgs e)
        {
            picturecita.BackColor = Color.FromArgb(49, 101, 244);
            lbcita.ForeColor = Color.FromArgb(255, 255, 255);
            lbcita.BackColor = Color.FromArgb(49, 101, 244);
            picturecita.Size = new System.Drawing.Size(129, 109);
            lbcita.Location = new Point(120, 401);
        }

        private void picturedoctor_MouseHover(object sender, EventArgs e)
        {
            picturedoctor.BackColor = Color.FromArgb(255, 255, 255);
            lbdoctor.BackColor = Color.FromArgb(255, 255, 255);
            lbdoctor.ForeColor = Color.FromArgb(49, 101, 244);
            picturedoctor.Size = new System.Drawing.Size(139, 119);
            lbdoctor.Location = new Point(392, 412);
        }

        private void picturedoctor_MouseLeave(object sender, EventArgs e)
        {
            picturedoctor.BackColor = Color.FromArgb(49, 101, 244);
            lbdoctor.ForeColor = Color.FromArgb(255, 255, 255);
            lbdoctor.BackColor = Color.FromArgb(49, 101, 244);
            picturedoctor.Size = new System.Drawing.Size(129, 109);
            lbdoctor.Location = new Point(386, 401);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void picturecita_Click(object sender, EventArgs e)
        {
            Cita m = new Cita();
            m.Show();
            this.Hide();
            MessageBox.Show("Recuerde ");
        }

        private void picturelaboratorio_Click(object sender, EventArgs e)
        {
            Laboratorio m = new Laboratorio();
            m.Show();
            this.Hide();
            MessageBox.Show("Laboratorio");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Examen m = new Examen();
            m.Show();
            this.Hide();
            MessageBox.Show("Bienvenido a Examenes");
        }

        private void picturedoctor_Click(object sender, EventArgs e)
        {
            Medico m = new Medico();
            m.Show();
            this.Hide();
            MessageBox.Show("Bienvenido a Medicos");
        }

        private void picturetrabajador_Click(object sender, EventArgs e)
        {
            Empleado m = new Empleado();
            m.Show();
            this.Hide();
            MessageBox.Show("Bienvenido a Empleado");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Factura m = new Factura();
            m.Show();
            this.Hide();
            MessageBox.Show("Bienvenido a Factura");
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            conexion con = new conexion();
            string[] a;
            this.Hide();
            Login l = new Login();
            l.Show();
            string sql = "SELECT MAX(id_bitacora) from bitacora";
            a = con.buscar(sql, 1);
            
            string sql2 = "UPDATE bitacora set hora_fin =  '"+ DateTime.Now.ToString("hh:mm:ss") + "' WHERE id_bitacora = "+ a[0] +"";
           
            con.IDU(sql2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bitacora bi = new Bitacora();
            bi.Show();
        }
    }
}
