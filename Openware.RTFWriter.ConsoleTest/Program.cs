using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Openware.RTFWriter;
namespace Openware.RTFWriter.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new RtfDocument(PaperSize.A4, PaperOrientation.Landscape, Lcid.English);
            FontDescriptor arial = doc.CreateFont("Arial");
            
            var times = doc.CreateFont("Times New Roman");
            RtfParagraph paragraph = doc.AddParagraph();
            paragraph.DefaultCharFormat.Font = arial;
            paragraph.DefaultCharFormat.AnsiFont = times;
            var text = "أحمد حمدان";
            paragraph.SetText(text);
            var fmt = paragraph.AddCharFormat(0,3);
            fmt.FontStyle.addStyle(FontStyleFlag.Bold);
         
            paragraph = doc.AddParagraph();
            paragraph.DefaultCharFormat.Font = arial;
            paragraph.DefaultCharFormat.AnsiFont = times;
            paragraph.SetText("محمد");
            doc.Save("Ahmad.RTF");

        }
    }
}
