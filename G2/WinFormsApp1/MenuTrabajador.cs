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
    public partial class MenuTrabajador : Form
    {
        public MenuTrabajador()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

            string sql2 = "UPDATE bitacora set hora_fin =  '" + DateTime.Now.ToString("hh:mm:ss") + "' WHERE id_bitacora = " + a[0] + "";

            con.IDU(sql2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ExamenR m = new ExamenR();
            m.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bitacora b = new Bitacora();
            b.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
