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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string id, nombres, apellidos, direccion, correo,sexo = " ",sangre, enfermedad, recomendacion;
            int dpi, telefono;

            id = txtid.Text;
            nombres = txtnombres.Text;
            apellidos = txtapellidos.Text;
            direccion = txtdireccion.Text;
            correo = txtcorreo.Text;
            dpi = Int32.Parse(txtdpi.Text);
            telefono = int.Parse(txttelefono.Text);
            sangre = txtsangre.Text;
            enfermedad = txtenfermedad.Text;
            recomendacion = txtrecomendacion.Text;


            if (radiohombre.Checked == true)
            {
                sexo = "Hombre";
            }
            if (radiomujer.Checked == true)
            {
                sexo = "Mujer";
            }


            string sql = "insert into cliente values" +
            " ('" + id + "'," + dpi + ",'" + nombres + "','" + apellidos +
            "'," + telefono + ",'" + correo + "','" + direccion + "')";

            conexion con = new conexion();
            con.IDU(sql);

            string sql2 = "insert into paciente values" +
           " ('" + id + "','" + id + "','" + sexo + "','" + sangre +
           "','" + enfermedad + "','" + recomendacion + "')";

            con.IDU(sql2);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtdpi.Clear();
            txtnombres.Clear();
            txtapellidos.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtcorreo.Clear();
            txtid.Focus();
            txtbuscar.Clear();
            txtenfermedad.Clear();
            txtrecomendacion.Clear();
            txtsangre.Clear();
            radiohombre.Checked = false;
            radiomujer.Checked = false;
            tabla.Rows.Clear();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtbuscar.Text;
            string[] cliente = new string[6];
            string[] paciente = new string[5];
            int n = tabla.Rows.Add();

            string sql = "select * from cliente where id_cliente = '" + buscar +"'";
            string sql2 = "select * from paciente where id_paciente = '" + buscar + "'";

            conexion con = new conexion();
           cliente =  con.buscar(sql, 7);
           paciente=  con.buscar(sql2, 6);


            tabla.Rows[n].Cells[0].Value = cliente[0];
            tabla.Rows[n].Cells[1].Value = cliente[1];
            tabla.Rows[n].Cells[2].Value = cliente[2];
            tabla.Rows[n].Cells[3].Value = cliente[3];
            tabla.Rows[n].Cells[4].Value = cliente[4];
            tabla.Rows[n].Cells[5].Value = cliente[5];
            tabla.Rows[n].Cells[6].Value = cliente[6];
            tabla.Rows[n].Cells[7].Value = paciente[2];
            tabla.Rows[n].Cells[8].Value = paciente[3];
            tabla.Rows[n].Cells[9].Value = paciente[4];
            tabla.Rows[n].Cells[10].Value = paciente[5];
          





        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buscar = tabla.Rows[0].Cells[0].Value.ToString();

            

            string sql = "delete from cliente where id_cliente = '"+buscar+"'";

            conexion con = new conexion();
            con.IDU(sql);

            tabla.Rows.RemoveAt(tabla.CurrentRow.Index);
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = tabla.CurrentRow.Cells[0].Value.ToString();
            txtdpi.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            txtnombres.Text = tabla.CurrentRow.Cells[2].Value.ToString();
            txtapellidos.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            txtcorreo.Text = tabla.CurrentRow.Cells[5].Value.ToString();
            txtdireccion.Text = tabla.CurrentRow.Cells[6].Value.ToString();
            
            txtsangre.Text = tabla.CurrentRow.Cells[8].Value.ToString();
            txtenfermedad.Text = tabla.CurrentRow.Cells[9].Value.ToString();
            txtrecomendacion.Text = tabla.CurrentRow.Cells[10].Value.ToString();

         
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string id, nombres, apellidos, direccion, correo, sexo = " ", sangre, enfermedad, recomendacion;
            int dpi, telefono;

            id = txtid.Text;
            nombres = txtnombres.Text;
            apellidos = txtapellidos.Text;
            direccion = txtdireccion.Text;
            correo = txtcorreo.Text;
            dpi = Int32.Parse(txtdpi.Text);
            telefono = int.Parse(txttelefono.Text);
            sangre = txtsangre.Text;
            enfermedad = txtenfermedad.Text;
            recomendacion = txtrecomendacion.Text;


            if (radiohombre.Checked == true)
            {
                sexo = "Hombre";
            }
            if (radiomujer.Checked == true)
            {
                sexo = "Mujer";
            }
 
            string sql3 = "delete from cliente where id_cliente = '" + id + "'";

            conexion con = new conexion();
            con.IDU(sql3);



         

            string sql = "insert into cliente values" +
            " ('" + id + "'," + dpi + ",'" + nombres + "','" + apellidos +
            "'," + telefono + ",'" + correo + "','" + direccion + "')";

            
            con.IDU(sql);

            string sql2 = "insert into paciente values" +
           " ('" + id + "','" + id + "','" + sexo + "','" + sangre +
           "','" + enfermedad + "','" + recomendacion + "')";

            con.IDU(sql2);
        }

        private void btnagregar_MouseHover(object sender, EventArgs e)
        {
            btnagregar.BackColor = Color.FromArgb(255, 255, 255);
            btnagregar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btnagregar_MouseLeave(object sender, EventArgs e)
        {
            btnagregar.BackColor = Color.FromArgb(49, 101, 244);
            btnagregar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnborrar_MouseHover(object sender, EventArgs e)
        {
            btnborrar.BackColor = Color.FromArgb(255, 255, 255);
            btnborrar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btnborrar_MouseLeave(object sender, EventArgs e)
        {
            btnborrar.BackColor = Color.FromArgb(49, 101, 244);
            btnborrar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnactualizar_MouseHover(object sender, EventArgs e)
        {
            btnactualizar.BackColor = Color.FromArgb(255, 255, 255);
            btnactualizar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btnactualizar_MouseLeave(object sender, EventArgs e)
        {
            btnactualizar.BackColor = Color.FromArgb(49, 101, 244);
            btnactualizar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackColor = Color.FromArgb(255, 255, 255);
            btncancelar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackColor = Color.FromArgb(49, 101, 244);
            btncancelar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnbuscar_MouseHover(object sender, EventArgs e)
        {
            btnbuscar.BackColor = Color.FromArgb(255, 255, 255);
            btnbuscar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btnbuscar_MouseLeave(object sender, EventArgs e)
        {
            btnbuscar.BackColor = Color.FromArgb(49, 101, 244);
            btnbuscar.ForeColor = Color.FromArgb(255, 255, 255);
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
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {

        }
    }
}
