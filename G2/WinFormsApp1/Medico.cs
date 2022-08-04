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
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string ID,name,lastn,email,adress,ocupation;
            int DPI;
            int tel;

            ID = txtID.Text;
            name = txtName.Text;
            DPI = int.Parse(txtDPI.Text);
            lastn = txtLastname.Text;
            email = txtEmail.Text;
            adress = txtAdress.Text;
            ocupation = txtOcupation.Text;
            tel = int.Parse(txtTel.Text);

            string sql = "insert into medico values" +
                "('" + ID + "'," + DPI + ",'" + name + "','" + lastn + "'," + tel + ",'"
                + email + "','" + adress + "','" + ocupation + "')";


            conexion con = new conexion();
            con.IDU(sql);
            detallebitacora d = new detallebitacora();
            d.agregar("Medico");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
            MessageBox.Show("Bienvenido a Menu");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtAdress.Clear();
            txtBuscar.Clear();
            txtDPI.Clear();
            txtEmail.Clear();
            txtID.Clear();
            txtLastname.Clear();
            txtName.Clear();
            txtOcupation.Clear();
            txtTel.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID, name, lastn, email, adress, ocupation;
            int DPI;
            int tel;

            ID = txtID.Text;
            name = txtName.Text;
            DPI = int.Parse(txtDPI.Text);
            lastn = txtLastname.Text;
            email = txtEmail.Text;
            adress = txtAdress.Text;
            ocupation = txtOcupation.Text;
            tel = int.Parse(txtTel.Text);

            string sql2 = "delete from medico where id_medico = '" + ID + "'";

            conexion con = new conexion();
            con.IDU(sql2);

            string sql = "insert into medico values" +
                "('" + ID + "'," + DPI + ",'" + name + "','" + lastn + "'," + tel + ",'"
                + email + "','" + adress + "','" + ocupation + "')";

            con.IDU(sql);
            detallebitacora d = new detallebitacora();
            d.actualizar("Medico");

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string buscar = table5.Rows[0].Cells[0].Value.ToString();

            string sql = "delete from medico where id_medico = '" + buscar + "'";

            conexion con = new conexion();
            con.IDU(sql);
            detallebitacora d = new detallebitacora();
            d.eliminar("Medico");

            table5.Rows.RemoveAt(table5.CurrentRow.Index);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            string[] medico = new string[7];

            int n = table5.Rows.Add();

            string sql = "select * from medico where id_medico = '" + buscar + "'";

            conexion con = new conexion();
            medico = con.buscar(sql, 8);
            detallebitacora d = new detallebitacora();
            d.busqueda("Medico");

            table5.Rows[n].Cells[0].Value = medico[0];
            table5.Rows[n].Cells[1].Value = medico[1];
            table5.Rows[n].Cells[2].Value = medico[2];
            table5.Rows[n].Cells[3].Value = medico[3];
            table5.Rows[n].Cells[4].Value = medico[4];
            table5.Rows[n].Cells[5].Value = medico[5];
            table5.Rows[n].Cells[6].Value = medico[6];
            table5.Rows[n].Cells[7].Value = medico[7];

        }
    }
}
