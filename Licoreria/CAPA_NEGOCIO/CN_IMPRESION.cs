using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class CN_IMPRESION
    {
        public static string directorio = Directory.GetCurrentDirectory();
        public void imprimirVenta(string html, string clinete, string departamento, int nroNota, string detalles, string totalNota, string fecha, string ubicaicon)
        {
            SaveFileDialog guard = new SaveFileDialog();

            guard.FileName = "Venta - " + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            //MessageBox.Show(guard.FileName);

            string direccio = ubicaicon + @"\" + guard.FileName;

            string paginaHtml = html;
            paginaHtml = paginaHtml.Replace("@CLIENTE", clinete);
            paginaHtml = paginaHtml.Replace("@CodCliente", departamento);
            paginaHtml = paginaHtml.Replace("@FECHA", fecha);
            paginaHtml = paginaHtml.Replace("@nronota", nroNota.ToString());
            paginaHtml = paginaHtml.Replace("@Filas", detalles);
            paginaHtml = paginaHtml.Replace("@TOTAL", totalNota);
            string filas = string.Empty;
            decimal total = 0;


            //if (guard.ShowDialog() == DialogResult.OK)
            //{
            //    if (guard.FileName == direccio)
            //    {
            //        MessageBox.Show("dfsdfsdsfd");
            //    }
            //}

            using (FileStream stream = new FileStream(direccio, FileMode.Create))
            {
                Document DocPdf = new Document(PageSize.A4, 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(DocPdf, stream);

                DocPdf.Open();

                DocPdf.Add(new Phrase(""));

                using (StringReader sr = new StringReader(paginaHtml))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, DocPdf, sr);
                }
                DocPdf.Close();
                stream.Close();

            }
        }
        public void imprimirRptVentaDia(string html, string usuario, string codUsuario, int nroNota, string detalles, string totalNota, string fechaIni, string fechaFin, string ubicaicon)
        {
            SaveFileDialog guard = new SaveFileDialog();

            guard.FileName = "Rpt_VentasPorDia - " + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            //MessageBox.Show(guard.FileName);

            string direccio = ubicaicon + @"\" + guard.FileName;

            string paginaHtml = html;
            paginaHtml = paginaHtml.Replace("@Usuario", usuario);
            paginaHtml = paginaHtml.Replace("@CodUsuario", codUsuario);
            paginaHtml = paginaHtml.Replace("@FECHAINI", fechaIni);
            paginaHtml = paginaHtml.Replace("@FECHAFIN", fechaFin);
            paginaHtml = paginaHtml.Replace("@nronota", nroNota.ToString());
            paginaHtml = paginaHtml.Replace("@Filas", detalles);
            paginaHtml = paginaHtml.Replace("@TOTAL", totalNota);
            string filas = string.Empty;
            decimal total = 0;


            //if (guard.ShowDialog() == DialogResult.OK)
            //{
            //    if (guard.FileName == direccio)
            //    {
            //        MessageBox.Show("dfsdfsdsfd");
            //    }
            //}

            using (FileStream stream = new FileStream(direccio, FileMode.Create))
            {
                Document DocPdf = new Document(PageSize.A4, 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(DocPdf, stream);

                DocPdf.Open();

                DocPdf.Add(new Phrase(""));

                using (StringReader sr = new StringReader(paginaHtml))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, DocPdf, sr);
                }
                DocPdf.Close();
                stream.Close();

            }
        }

    }
}
