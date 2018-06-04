using PIM.ClassProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    public class GeradorNfe
    {

        public void GerarNFE(ClassCliente.Cliente cli, ClassColaborador.Colaborador col, ClassPN.PN p, Int32 tC, List<Produto> Tpro, int idV)
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var font = new PdfSharp.Drawing.XFont("Arial", 12);

                
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                textFormatter.DrawString("NFE N: " + idV + " - Nota Fiscal de compra - Lojas PIM artigos esportivos", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 30, page.Width, page.Height));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                


                textFormatter.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 50, page.Width, page.Height));



                textFormatter.DrawString("Razão Social: Rodrigo Santos LTDA", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 70, page.Width, page.Height));
                textFormatter.DrawString("CNPJ: 10.273.567/0001-19", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 70, page.Width, page.Height));

                textFormatter.DrawString("Endereço: Rua Leblon 148", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 90, page.Width, page.Height));
                textFormatter.DrawString("Bairro: Jardim São Vicente ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 90, page.Width, page.Height));

                textFormatter.DrawString("Cidade: Embu das Artes (região metropolitana de São Paulo)", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 110, page.Width, page.Height));
                textFormatter.DrawString("Estado: São Paulo ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 110, page.Width, page.Height));

                textFormatter.DrawString("Telefone: 16-99138-2929 / 16-3622-3743", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 140, page.Width, page.Height));
                textFormatter.DrawString("Email: sac@pimesporte.com.br ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 140, page.Width, page.Height));

                textFormatter.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 160, page.Width, page.Height));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                textFormatter.DrawString("DADOS DO CLIENTE", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 180, page.Width, page.Height));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;

                if (tC == 1)
                {
                    textFormatter.DrawString("Nome: " + cli.nome, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 200, page.Width, page.Height));
                    textFormatter.DrawString("CPF: " + cli.cpf, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 200, page.Width, page.Height));

                    textFormatter.DrawString("Endereço: " + cli.logradouro, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 220, page.Width, page.Height));
                    textFormatter.DrawString("Número: " + cli.numero, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 220, page.Width, page.Height));

                    textFormatter.DrawString("Estado: " + cli.estado, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 240, page.Width, page.Height));
                    textFormatter.DrawString("País : " + cli.pais, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 240, page.Width, page.Height));

                    textFormatter.DrawString("E-mail : " + cli.email, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 260, page.Width, page.Height));

                }
                else if (tC == 2)
                {
                    textFormatter.DrawString("Nome: " + col.nome, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 200, page.Width, page.Height));
                    textFormatter.DrawString("CPF: " + col.cpf, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 200, page.Width, page.Height));

                    textFormatter.DrawString("Endereço: " + col.logradouro, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 220, page.Width, page.Height));
                    textFormatter.DrawString("Número: " + col.num, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 220, page.Width, page.Height));

                    textFormatter.DrawString("Estado: " + col.estado, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 240, page.Width, page.Height));
                    textFormatter.DrawString("País : " + col.pais, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 240, page.Width, page.Height));

                    textFormatter.DrawString("E-mail : " + col.email, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 260, page.Width, page.Height));

                }
                else 
                {
                    textFormatter.DrawString("Nome: " + p.rsocial, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 200, page.Width, page.Height));
                    textFormatter.DrawString("CNPJ: " + p.cnpj, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 200, page.Width, page.Height));

                    textFormatter.DrawString("Endereço: " + p.logradouro, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 220, page.Width, page.Height));
                    textFormatter.DrawString("Número: " + p.num, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 220, page.Width, page.Height));

                    textFormatter.DrawString("Estado: " + p.estado, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 240, page.Width, page.Height));
                    textFormatter.DrawString("País : " + p.pais, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(400, 240, page.Width, page.Height));

                    textFormatter.DrawString("E-mail : " + p.email, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 260, page.Width, page.Height));

                }


                textFormatter.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 280, page.Width, page.Height));

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                textFormatter.DrawString("PRODUTOS ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, 300, page.Width, page.Height));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;

                int i = 320;
                Double v = 0;
                foreach (var pr in Tpro)
                {
                    i = i + 20;
                    textFormatter.DrawString(pr.marca + " - " + pr.nome, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, i, page.Width, page.Height));
                    textFormatter.DrawString("R$ " + pr.valor, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(500, i, page.Width, page.Height));
                    v = v + pr.valor;
                }
                textFormatter.DrawString("TOTAL ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, (i + 20), page.Width, page.Height));
                textFormatter.DrawString("R$ " + v, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(500, (i + 20), page.Width, page.Height));
                textFormatter.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, (i + 40), page.Width, page.Height));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                textFormatter.DrawString("Não será aceito devolução de produtos com defeito, não será aceito produtos sem etiqueta ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, (i + 60), page.Width, page.Height));
                textFormatter.DrawString("GRATO PELA PREFERENCIA, VOLTE SEMPRE! ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(10, (i + 80), page.Width, page.Height));


                doc.Save("Arquivo.pdf");
                System.Diagnostics.Process.Start("Arquivo.pdf");

            }
        }
    }
}
