using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using OpenXmlFactory;
using Tag = OpenXmlFactory.Tag;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var outerXml =
                "<w:p w:rsidRPr=\"00974A4B\" w:rsidR=\"00D3074F\" w:rsidP=\"00D3074F\" w:rsidRDefault=\"00974A4B\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:pPr><w:pStyle w:val=\"Title\" /><w:pBdr><w:top w:val=\"single\" w:color=\"C0504D\" w:sz=\"48\" w:space=\"0\" /><w:bottom w:val=\"single\" w:color=\"C0504D\" w:sz=\"48\" w:space=\"0\" /></w:pBdr><w:shd w:val=\"clear\" w:color=\"auto\" w:fill=\"C0504D\" /><w:rPr><w:rFonts w:ascii=\"Calibri\" w:hAnsi=\"Calibri\" /><w:b /><w:iCs w:val=\"0\" /><w:color w:val=\"FFFFFF\" /><w:sz w:val=\"36\" /><w:szCs w:val=\"36\" /><w:lang w:val=\"nl-NL\" /></w:rPr></w:pPr><w:proofErr w:type=\"spellStart\" /><w:r w:rsidRPr=\"00974A4B\"><w:rPr><w:rFonts w:ascii=\"Calibri\" w:hAnsi=\"Calibri\" /><w:b /><w:iCs w:val=\"0\" /><w:smallCaps /><w:color w:val=\"FFFFFF\" /><w:sz w:val=\"36\" /><w:szCs w:val=\"36\" /><w:lang w:val=\"nl-NL\" /></w:rPr><w:t>Projectspecifieke</w:t></w:r><w:proofErr w:type=\"spellEnd\" /><w:r w:rsidRPr=\"00974A4B\"><w:rPr><w:rFonts w:ascii=\"Calibri\" w:hAnsi=\"Calibri\" /><w:b /><w:iCs w:val=\"0\" /><w:smallCaps /><w:color w:val=\"FFFFFF\" /><w:sz w:val=\"36\" /><w:szCs w:val=\"36\" /><w:lang w:val=\"nl-NL\" /></w:rPr><w:t xml:space=\"preserve\"> Voorwaarden</w:t></w:r></w:p>";
            var outerXml2 =
                "<w:color w:val=\"FFFFFF\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" />";
            var outerXml3 =
                "<w:rPr xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:rFonts w:ascii=\"Calibri\" w:hAnsi=\"Calibri\" /><w:b /><w:iCs w:val=\"0\" /><w:color w:val=\"FFFFFF\" /><w:sz w:val=\"36\" /><w:szCs w:val=\"36\" /><w:lang w:val=\"nl-NL\" /></w:rPr>";


            var element1 = new OpenXmlElementReconstructor().Reconstruct(outerXml);
            var element2 = new OpenXmlElementReconstructor().Reconstruct(outerXml2);
            var element3 = new OpenXmlElementReconstructor().Reconstruct(outerXml3);

            GetARandomParagraph();
        }

        private static void GetARandomParagraph()
        {
            using (var document = WordprocessingDocument.Open(@"c:\temp\InsertInDocument.docx", false))
            {
                var something = document.MainDocumentPart.RootElement.Descendants();
                var outerXml = something.ElementAt(8).OuterXml;
            }
        }

    }
}
