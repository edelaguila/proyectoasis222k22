﻿using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LaboratorioClinico
{
    public partial class ExamenR : Form
    {
        public ExamenR()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            crearPDF();

            



        }
        private void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("Reporte_Examen.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            // 1 pulgada = 72 pt (8 1/2 x 11) (8.5*72) (612x792)
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "ID_Examen", "ID_Paciente", "Nombre", "Tipo", "Precio" };

            float[] tamanios = {2, 2, 4, 4, 2};
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql6 = "SELECT e.id_examen, e.paciente, e.nombre, e.tipo, e.precio FROM examen AS e ";

            MySqlConnection conexionBD = conexionR.conexion();
            conexionBD.Open();

            MySqlCommand comando = new MySqlCommand(sql6, conexionBD);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                

                
                tabla.AddCell(new Cell().Add(new Paragraph(reader["id_examen"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["paciente"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["nombre"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["tipo"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["precio"].ToString()).SetFont(fontContenido)));
                
            }

            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/Kuht_saal/Desktop/Torres/proyectoasis222k22/G2/WinFormsApp1/img/Examenes.png")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);
            var titulo = new Paragraph("Reporte de Examenes");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha =  DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " +dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte_Examen.pdf"), new PdfWriter("ReporteTest.pdf"));
            Document doc = new Document(pdfDoc);

            int numeros = pdfDoc.GetNumberOfPages();

            for(int i= 1; i<=numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 150, y -15, i,TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), 
                    pdfDoc.GetPage (i).GetPageSize().GetWidth() /2, pdfDoc.GetPage(i).GetPageSize().GetBottom()+30, i,
                    TextAlignment.CENTER, VerticalAlignment.TOP, 0);
            }
            doc.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuTrabajador m = new MenuTrabajador();
            m.Show();
            this.Hide();
        }

        private void ExamenR_Load(object sender, EventArgs e)
        {

        }

        
    }
}
