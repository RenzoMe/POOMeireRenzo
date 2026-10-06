using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using POOMeireRenzo.Dto;
using Font = iTextSharp.text.Font; 

namespace POOMeireRenzo.Services
{
    public class PdfReportService
    {
        public void GenerarPdfPresupuesto(PresupuestoDto presupuesto, string rutaArchivo)
        {
            Document documento = new Document(PageSize.A4, 25, 25, 25, 25);
            PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));

            documento.Open();

            Font fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            Font fuenteTexto = FontFactory.GetFont(FontFactory.HELVETICA, 11);
            Font fuenteBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);

            documento.Add(new Paragraph("PRESUPUESTO DE EVENTO N° " + presupuesto.Id.ToString(), fuenteTitulo));
            documento.Add(new Paragraph("Cliente: " + presupuesto.Cliente.Nombre, fuenteTexto));
            documento.Add(new Paragraph("Documento: " + presupuesto.Cliente.Documento, fuenteTexto));
            documento.Add(new Paragraph("Teléfono: " + presupuesto.Cliente.Telefono, fuenteTexto));
            documento.Add(new Paragraph(" ", fuenteTexto));

            PdfPTable tabla = new PdfPTable(4);
            tabla.WidthPercentage = 100;

            tabla.AddCell(new PdfPCell(new Phrase("Categoría", fuenteBold)));
            tabla.AddCell(new PdfPCell(new Phrase("Descripción", fuenteBold)));
            tabla.AddCell(new PdfPCell(new Phrase("Cantidad", fuenteBold)));
            tabla.AddCell(new PdfPCell(new Phrase("Subtotal", fuenteBold)));

            foreach (ItemPresupuestoDto item in presupuesto.Items)
            {
                tabla.AddCell(new PdfPCell(new Phrase(item.Tipo, fuenteTexto)));
                tabla.AddCell(new PdfPCell(new Phrase(item.Descripcion, fuenteTexto)));
                tabla.AddCell(new PdfPCell(new Phrase(item.Cantidad.ToString(), fuenteTexto)));
                tabla.AddCell(new PdfPCell(new Phrase("$ " + item.Subtotal.ToString("N2"), fuenteTexto)));
            }

            documento.Add(tabla);
            documento.Add(new Paragraph(" ", fuenteTexto));

            documento.Add(new Paragraph("TOTAL ESTIMADO: $ " + presupuesto.Total.ToString("N2"), fuenteTitulo));

            documento.Close();
        }
    }
}