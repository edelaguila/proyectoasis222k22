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
    public partial class Cita : Form
    {
        public Cita()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cita_Load(object sender, EventArgs e)
        {

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string id_cita, paciente, laboratorio;
            float precio;
            String fechaInicio, fechaFin, horaInicio;
      
            id_cita = txt_id.Text;
            paciente = txt_Nombre.Text;
            laboratorio = txt_Laboratorio.Text;
           
            fechaInicio = txtInicio.Value.ToString("yyyyMMdd");
            fechaFin = txtFin.Value.ToString("yyyyMMdd");
            horaInicio = txtHora.Value.ToString("hh:mm:ss");

            precio = float.Parse(txt_Precio.Text);

            string sql = "insert into cita values" +
           " ('" + id_cita + "','" + paciente + "','" + laboratorio + "','" + fechaInicio +
           "','" + horaInicio + "','" + fechaFin + "','" + precio + "')";


            conexion con = new conexion();
            con.IDU(sql);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_Nombre.Clear();
            txt_Laboratorio.Clear();
            txtInicio.CalendarFont = null;
            txtFin.CalendarFont = null;
            txtHora.CalendarFont = null;
        }

        private void btnbuscar2_Click(object sender, EventArgs e)
        {
            string buscar = txtbuscar2.Text;
            string[] cita = new string[6];
            int n = tabla2.Rows.Add();

            string sql = "select * from cita where id_cita = '" + buscar + "'";
           

            conexion con = new conexion();
            cita = con.buscar(sql, 7);
           


            tabla2.Rows[n].Cells[0].Value = cita[0];
            tabla2.Rows[n].Cells[1].Value = cita[1];
            tabla2.Rows[n].Cells[2].Value = cita[2];
            tabla2.Rows[n].Cells[3].Value = cita[3];
            tabla2.Rows[n].Cells[4].Value = cita[4];
            tabla2.Rows[n].Cells[5].Value = cita[5];
            tabla2.Rows[n].Cells[6].Value = cita[6];
         

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            string buscar = tabla2.Rows[0].Cells[0].Value.ToString();

            string sql = "delete from cita where id_dita = '" + buscar + "'";

            conexion con = new conexion();
            con.IDU(sql);

            tabla2.Rows.RemoveAt(tabla2.CurrentRow.Index);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string id_cita, paciente, laboratorio;
            float precio;
            String fechaInicio, fechaFin, horaInicio;

            id_cita = txt_id.Text;
            paciente = txt_Nombre.Text;
            laboratorio = txt_Laboratorio.Text;

            fechaInicio = txtInicio.Value.ToString("yyyyMMdd");
            fechaFin = txtFin.Value.ToString("yyyyMMdd");
            horaInicio = txtHora.Value.ToString("hh:mm:ss");

            precio = float.Parse(txt_Precio.Text);


            string sql3 = "delete from cita where id_cita = '" + id_cita + "'";

            conexion con = new conexion();
            con.IDU(sql3);


            string sql = "insert into cita values" +
          " ('" + id_cita + "','" + paciente + "','" + laboratorio + "','" + fechaInicio +
          "','" + horaInicio + "','" + fechaFin + "','" + precio + "')";


            con.IDU(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabla2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
