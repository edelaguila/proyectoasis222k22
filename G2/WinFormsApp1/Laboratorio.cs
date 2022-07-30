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
    public partial class Laboratorio : Form
    {
        public Laboratorio()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtAdress.Clear();
            txtBuscar.Clear();
            txtID.Clear();
            txtMedico.Clear();
            txtName.Clear();
            txtTel.Clear();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string ID, name, adress, medico;
            int tel;

            ID = txtID.Text;
            medico = txtMedico.Text;
            name = txtName.Text;
            adress = txtAdress.Text;
            tel = int.Parse(txtTel.Text);

            string sql = "insert into laboratorio values" +
                "('" + ID + "','" + medico + "','" + name + "','" + adress +
                "'," + tel + ")";

            conexion con = new conexion();
            con.IDU(sql);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID, name, adress, medico;
            int tel;

            ID = txtID.Text;
            medico = txtMedico.Text;
            name = txtName.Text;
            adress = txtAdress.Text;
            tel = int.Parse(txtTel.Text);

            string sql2 = "delete from laboratorio where id_laboratorio = '" + ID + "'";

            conexion con = new conexion();
            con.IDU(sql2);

            string sql = "insert into laboratorio values" +
                "('" + ID + "','" + medico + "','" + name + "','" + adress +
                "'," + tel + ")";

            con.IDU(sql);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string buscar = table6.Rows[0].Cells[0].Value.ToString();

            string sql = "delete from laboratorio where id_laboratorio = '" + buscar + "'";

            conexion con = new conexion();
            con.IDU(sql);

            table6.Rows.RemoveAt(table6.CurrentRow.Index);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            string[] laboratorio = new string[4];

            int n = table6.Rows.Add();

            string sql = "select * from laboratorio where id_laboratorio = '" + buscar + "'";

            conexion con = new conexion();
            laboratorio = con.buscar(sql, 5);

            table6.Rows[n].Cells[0].Value = laboratorio[0];
            table6.Rows[n].Cells[1].Value = laboratorio[1];
            table6.Rows[n].Cells[2].Value = laboratorio[2];
            table6.Rows[n].Cells[3].Value = laboratorio[3];
            table6.Rows[n].Cells[4].Value = laboratorio[4];
        }
    }
}
