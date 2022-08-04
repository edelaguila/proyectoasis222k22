using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;

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

        private void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("Reporte_Bitacora.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            // 1 pulgada = 72 pt (8 1/2 x 11) (8.5*72) (612x792)
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "ID_Bitacora", "bitacora", "Modulo", "Accion", "Hora" };

            float[] tamanios = { 2, 2, 4, 4, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql6 = "SELECT e.id_detalle, e.bitacora, e.modulo, e.accion, e.hora FROM detallebitacora AS e ";

            MySqlConnection conexionBD = conexionR.conexion();
            conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql6, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {



                tabla.AddCell(new Cell().Add(new Paragraph(reader["id_detalle"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["bitacora"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["modulo"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["accion"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["hora"].ToString()).SetFont(fontContenido)));

            }

            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create(@"C:\Users\luist\OneDrive\Universidad\8semestre\Analisis2\proyecto1\proyectoasis222k22\G2\WinFormsApp1\img\reporte.png")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);
            var titulo = new Paragraph("Reporte de Bitacora");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte_Bitacora.pdf"), new PdfWriter("ReporteTes.pdf"));
            Document doc = new Document(pdfDoc);

            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i <= numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)),
                    pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i,
                    TextAlignment.CENTER, VerticalAlignment.TOP, 0);
            }
            doc.Close();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            crearPDF();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
