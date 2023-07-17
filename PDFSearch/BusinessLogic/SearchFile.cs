using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using GrapeCity.Documents.Pdf;
using GrapeCity.Documents.Pdf.Log;
using PDFSearch.BusinessLogic.Model;
using UglyToad.PdfPig;
using Color = System.Drawing.Color;
using Path = System.IO.Path;

namespace PDFSearch.BusinessLogic
{
    public static class SearchFile
    {
        public static string WordFilePath { get; set; }
        public static List<string> WordsToSearch { get; set; } = new List<string>();
        public static List<FoundWord> FoundWords { get; set; } = new List<FoundWord>();

        public static void SaveFileName(string fileName)
        {
            WordFilePath = fileName;
        }
        public static void AddWordsToSearch(string fileName)
        {
            WordprocessingDocument document = WordprocessingDocument.Open(fileName, true);
            Body docBody = document.MainDocumentPart.Document.Body;
            foreach (var paragraph in document.MainDocumentPart.RootElement.Descendants<Paragraph>())
            {
                GetWordsFromLine(paragraph);
            }
        }

        private static void GetWordsFromLine(Paragraph paragraph)
        {
            var lineText = paragraph.InnerText;
            if (!string.IsNullOrEmpty(lineText))
                WordsToSearch.Add(lineText);
        }

        public static List<FoundWord> ProcessPDFDocument()
        {
            var fileName = WordFilePath;
            var newDocument = new GcPdfDocument();
            //var date = DateTime.Today.ToShortDateString();
            //var dateFormatted = date.Replace("/", "_");
            //var time = DateTime.Now.ToShortTimeString();
            //var timeFormatted = time.Replace(" ", "_");
            using (var fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                newDocument.Load(fileStream);
                foreach (var word in WordsToSearch)
                {
                    FindAndHighlightWord(newDocument, word);
                }
                newDocument.Save(fileName);
            }

            return FoundWords;
        }

        public static void FindAndHighlightWord(GcPdfDocument document, string word)
        {
            var positions = document.FindText(new FindTextParams(word, false, false));

            foreach (var position in positions)
            {
                document.Pages[position.PageIndex]
                           .Graphics.FillPolygon(position.Bounds[0],
                               System.Drawing.Color.FromArgb(100, Color.LightSeaGreen));
                FoundWord foundWord = new FoundWord();
                foundWord.Position = position;
                foundWord.Word = word;
                FoundWords.Add(foundWord);
            }
        }

    }
}
