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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string id, nombres, apellidos, direccion, correo, usuario;
            int  telefono;
            id = txtid.Text;
            usuario = txtusuario.Text;
            nombres = txtnombres.Text;
            apellidos = txtapellidos.Text;
            direccion = txtdireccion.Text;
            correo = txtcorreo.Text;
            telefono = int.Parse(txttelefono.Text);
            int n = tabla.Rows.Add();


            string sql = "insert into empleado values" +
            " ('" + id + "','" + usuario + "','" + nombres + "','" + apellidos +
            "'," + telefono + ",'" + correo + "','" + direccion + "')";

            conexion con = new conexion();
            con.IDU(sql);
            detallebitacora d = new detallebitacora();
            d.agregar("Empleado");


            tabla.Rows[n].Cells[0].Value = txtid.Text;
            tabla.Rows[n].Cells[1].Value = txtusuario.Text;
            tabla.Rows[n].Cells[2].Value = txtnombres.Text;
            tabla.Rows[n].Cells[3].Value = txtapellidos.Text;
            tabla.Rows[n].Cells[4].Value = txttelefono.Text;
            tabla.Rows[n].Cells[5].Value = txtcorreo.Text;
            tabla.Rows[n].Cells[6].Value = txtdireccion.Text;

            txtusuario.Enabled = false;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            string buscar = tabla.Rows[0].Cells[0].Value.ToString();



            string sql = "delete from empleado where id_empleado = '" + buscar + "'";

            conexion con = new conexion();
            con.IDU(sql);
            detallebitacora d = new detallebitacora();
            d.eliminar("Empleado");

            tabla.Rows.RemoveAt(tabla.CurrentRow.Index);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtid.Clear();
            txtnombres.Clear();
            txtapellidos.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtcorreo.Clear();
            txtid.Focus();
            txtbuscar.Clear();
            tabla.Rows.Clear();
            
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            string id, nombres, apellidos, direccion, correo, usuario;
            int telefono;
            id = txtid.Text;
            usuario = txtusuario.Text;
            nombres = txtnombres.Text;
            apellidos = txtapellidos.Text;
            direccion = txtdireccion.Text;
            correo = txtcorreo.Text;
            telefono = int.Parse(txttelefono.Text);

            string sql1 = "delete from empleado where id_empleado = '" + id + "'";
            conexion con = new conexion();
            con.IDU(sql1);



            string sql = "insert into empleado values" +
            " ('" + id + "','" + usuario + "','" + nombres + "','" + apellidos +
            "'," + telefono + ",'" + correo + "','" + direccion + "')";

            con.IDU(sql);
            detallebitacora d = new detallebitacora();
            d.actualizar("Empleado");


        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtbuscar.Text;
            string[] empleado = new string[7];
            int n = tabla.Rows.Add();

            string sql = "select * from empleado where id_empleado = '" + buscar + "'";
        

            conexion con = new conexion();
            empleado = con.buscar(sql, 7);
            detallebitacora d = new detallebitacora();
            d.busqueda("Empleado");


            tabla.Rows[n].Cells[0].Value = empleado[0];
            tabla.Rows[n].Cells[1].Value = empleado[1];
            tabla.Rows[n].Cells[2].Value = empleado[2];
            tabla.Rows[n].Cells[3].Value = empleado[3];
            tabla.Rows[n].Cells[4].Value = empleado[4];
            tabla.Rows[n].Cells[5].Value = empleado[5];
            tabla.Rows[n].Cells[6].Value = empleado[6];
            
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = tabla.CurrentRow.Cells[0].Value.ToString();
            txtusuario.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            txtnombres.Text = tabla.CurrentRow.Cells[2].Value.ToString();
            txtapellidos.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            txtcorreo.Text = tabla.CurrentRow.Cells[5].Value.ToString();
            txtdireccion.Text = tabla.CurrentRow.Cells[6].Value.ToString();
            txtusuario.Enabled = false;

           
        }
        
        
        private void btnagregar_MouseHover_1(object sender, EventArgs e)
        {
            btnagregar.BackColor = Color.FromArgb(255, 255, 255);
            btnagregar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btnagregar_MouseLeave_1(object sender, EventArgs e)
        {
            btnagregar.BackColor = Color.FromArgb(49, 101, 244);
            btnagregar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnborrar_MouseHover_1(object sender, EventArgs e)
        {
            btnborrar.BackColor = Color.FromArgb(255, 255, 255);
            btnborrar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btnborrar_MouseLeave_1(object sender, EventArgs e)
        {
            btnborrar.BackColor = Color.FromArgb(49, 101, 244);
            btnborrar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnactualizar_MouseHover_1(object sender, EventArgs e)
        {
            btnactualizar.BackColor = Color.FromArgb(255, 255, 255);
            btnactualizar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btnactualizar_MouseLeave_1(object sender, EventArgs e)
        {
            btnactualizar.BackColor = Color.FromArgb(49, 101, 244);
            btnactualizar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btncancelar_MouseHover_1(object sender, EventArgs e)
        {
            btncancelar.BackColor = Color.FromArgb(255, 255, 255);
            btncancelar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btncancelar_MouseLeave_1(object sender, EventArgs e)
        {
            btncancelar.BackColor = Color.FromArgb(49, 101, 244);
            btncancelar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnbuscar_MouseHover_1(object sender, EventArgs e)
        {
            btnbuscar.BackColor = Color.FromArgb(255, 255, 255);
            btnbuscar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btnbuscar_MouseLeave_1(object sender, EventArgs e)
        {
            btnbuscar.BackColor = Color.FromArgb(49, 101, 244);
            btnbuscar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnregresar_MouseHover_1(object sender, EventArgs e)
        {
            btnregresar.BackColor = Color.FromArgb(255, 255, 255);
            btnregresar.ForeColor = Color.FromArgb(49, 101, 244);
        }

        private void btnregresar_MouseLeave_1(object sender, EventArgs e)
        {
            btnregresar.BackColor = Color.FromArgb(49, 101, 244);
            btnregresar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
    }
}
