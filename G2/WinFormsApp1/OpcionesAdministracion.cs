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
    public partial class OpcionesAdministracion : Form
    {
        public OpcionesAdministracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cita m = new Cita();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Factura m = new Factura();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paciente m = new Paciente();
            m.Show();
            this.Hide();
        }

        private void OpcionesAdministracion_Load(object sender, EventArgs e)
        {

        }
    }
}
