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
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            conexion con = new conexion();
            string usuario, fechainicio, fechafin;
        
            usuario = txtusuario.Text;
            fechainicio = dtpinicial.Value.ToString("yyyyMMdd");
            fechafin = dtpfinal.Value.ToString("yyyyMMdd");
            


            string sql3 = "select id_bitacora from bitacora where usuario = '" + usuario + "' and fecha >= '" + fechainicio + "' and fecha <= '" + fechafin + "'";
            list.DataSource = con.Busqueda(sql3);
            list.DisplayMember = "fname";
            list.ValueMember = "id_bitacora";     
          
            


        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion con = new conexion();
            string usuario;

            string[] bitacora = new string[5];
            usuario = txtusuario.Text;

           
            if (txtid.Text == " ")
            {

                MessageBox.Show("El listbox esta vacio");
            }
            else
            {
                txtid.Text = list.Text;

                string sql = "select * from bitacora where usuario = '" + usuario + "' and id_bitacora = " + txtid.Text + "";
                bitacora = con.buscar(sql, 5);


                txtfecha.Text = bitacora[2];
                txthorainicio.Text = bitacora[3];
                txthorafin.Text = bitacora[4];


                string sql2 = "select * from detallebitacora where bitacora = " + txtid.Text + "";
                tabla.DataSource = con.Busqueda(sql2);
            }
        }
    }
}
