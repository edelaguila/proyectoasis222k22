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
    public partial class Examen : Form
    {
        public Examen()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            txtID.Clear();
            txtName.Clear();
            txtPaciente.Clear();
            txtPrecio.Clear();
            txtTipo.Clear();
            txtBuscar.Clear();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string ID, name, paciente, tipo;
            float precio;

            ID= txtID.Text;
            name= txtName.Text;
            paciente = txtPaciente.Text;
            tipo = txtTipo.Text;
            precio= float.Parse(txtPrecio.Text);

            string sql = "insert into examen values" +
                "('" + ID + "','" + paciente + "','" + name + "','" + tipo +
                "'," + precio + ")";

            conexion con = new conexion();
            con.IDU(sql);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID, name, paciente, tipo;
            float precio;

            ID = txtID.Text;
            name = txtName.Text;
            paciente = txtPaciente.Text;
            tipo = txtTipo.Text;
            precio = float.Parse(txtPrecio.Text);

            string sql2 = "delete from examen where id_examen = '" + ID + "'";

            conexion con = new conexion();
            con.IDU(sql2);

            string sql = "insert into examen values" +
               "('" + ID + "','" + paciente + "','" + name + "','" + tipo +
               "'," + precio + ")";
            con.IDU(sql);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string buscar= txtBuscar.Text;
            string[] examen = new string[4];

            int n = table4.Rows.Add();

            string sql = "select * from examen where id_examen = '" + buscar + "'";

            conexion con = new conexion();
            examen = con.buscar(sql, 5);

            table4.Rows[n].Cells[0].Value = examen[0];
            table4.Rows[n].Cells[1].Value = examen[1];
            table4.Rows[n].Cells[2].Value = examen[2];
            table4.Rows[n].Cells[3].Value = examen[3];
            table4.Rows[n].Cells[4].Value = examen[4];

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string buscar = table4.Rows[0].Cells[0].Value.ToString();

            string sql = "delete from examen where id_examen = '" + buscar + "'";

            conexion con = new conexion();
            con.IDU(sql);

            table4.Rows.RemoveAt(table4.CurrentRow.Index);
        }

        private void Examen_Load(object sender, EventArgs e)
        {

        }
    }
}
