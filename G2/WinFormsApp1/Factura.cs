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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtFecha.CalendarFont = null;
            txtClient.Clear();
            txtCita.Clear();
            txtTest.Clear();
            txtTotal.Clear();
            txtBuscar.Clear();
            txtPrice.Clear();
            rdbCheck.Checked = false;
            rdbCredit.Checked = false;
            rdbMoney.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID, cliente, cita, examen, tipo = " ";
            float Total = 0, precio;
            String fecha;

            ID = txtID.Text;
            fecha = txtFecha.Value.ToString("yyyyMMdd");
            cliente = txtClient.Text;
            cita = txtCita.Text;
            examen = txtTest.Text;
            precio = float.Parse(txtPrice.Text);

            if (rdbMoney.Checked == true)
            {
                tipo = "Efectivo";
            }
            if (rdbCheck.Checked == true)
            {
                tipo = "Cheque";

            }
            if (rdbCredit.Checked == true)
            {
                tipo = "Crédito";
            }



            if (tipo.Equals("Efectivo"))
            {
                Total = precio;
            }
            if (tipo.Equals("Cheque"))
            {
                Total = precio;
            }
            if (tipo.Equals("Crédito"))
            {
                Total = ((float)(precio * 1.05));
            }
            string total2;
            total2 = Total.ToString();
            txtTotal.Enabled = true;
            txtTotal.Text = total2;

            string sql3 = "delete from factura where id_factura = '" + ID + "'";

            conexion con = new conexion();
            con.IDU(sql3);

            string sql = "insert into factura values" +
                "('" + ID + "','" + fecha + "','" + cliente + "','" + tipo + "'," + Total + ")";

            con.IDU(sql);

            string sql2 = "insert into detalle values" +
                "('" + ID + "','" + ID + "','" + cita + "','" + examen + "')";

            con.IDU(sql2);
            detallebitacora d = new detallebitacora();
            d.actualizar("Factura");

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string buscar = tabla3.Rows[0].Cells[0].Value.ToString();

            string sql ="delete from factura where id_factura = '" + buscar + "'";

            conexion con = new conexion();
            con.IDU(sql);
            detallebitacora d = new detallebitacora();
            d.eliminar("Factura");

            tabla3.Rows.RemoveAt(tabla3.CurrentRow.Index);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ID, cliente, cita, examen, tipo= " ";
            float Total=0, precio;
            String fecha;

            ID = txtID.Text;
            fecha = txtFecha.Value.ToString("yyyyMMdd");
            cliente = txtClient.Text;
            cita = txtCita.Text;
            examen = txtTest.Text;
            precio = float.Parse(txtPrice.Text);

            if (rdbMoney.Checked == true)
            {
                tipo = "Efectivo";
            }
            if (rdbCheck.Checked == true)
            {
                tipo = "Cheque";

            }
            if (rdbCredit.Checked == true)
            {
                tipo = "Crédito";
            }



            if (tipo.Equals("Efectivo"))
            {
                Total = precio;
            }
            if (tipo.Equals("Cheque"))
            {
                Total = precio;
            }
            if (tipo.Equals("Crédito"))
            {
                Total = ((float)(precio * 1.05));
            }
            string total2;
            total2 = Total.ToString();
            txtTotal.Enabled = true;
            txtTotal.Text = total2;

            string sql = "insert into factura values" +
                "('" + ID + "','" + fecha + "','" + cliente + "','" + tipo + "'," + Total + ")";

            conexion con = new conexion();
            con.IDU(sql);

            string sql2 = "insert into detalle values" +
                "('" + ID + "','" + ID + "','" + cita + "','" + examen + "')";

            con.IDU(sql2);
            detallebitacora d = new detallebitacora();
            d.agregar("Factura");


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            string[] factura = new string[4];
            string[] detalle = new string[3];
            int n = tabla3.Rows.Add();

            string sql = "select * from factura where id_factura = '" + buscar + "'";
            string sql2 = "select * from detalle where id_detalle = '" + buscar + "'";

            conexion con = new conexion();
            factura = con.buscar(sql, 5);
            detalle = con.buscar(sql2, 4);
            detallebitacora d = new detallebitacora();
            d.busqueda("Factura");

            tabla3.Rows[n].Cells[0].Value = factura[0];
            tabla3.Rows[n].Cells[1].Value = factura[1];
            tabla3.Rows[n].Cells[2].Value = factura[2];
            tabla3.Rows[n].Cells[3].Value = detalle[2];
            tabla3.Rows[n].Cells[4].Value = detalle[3];
            tabla3.Rows[n].Cells[5].Value = factura[3];
            tabla3.Rows[n].Cells[6].Value = factura[4];

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
