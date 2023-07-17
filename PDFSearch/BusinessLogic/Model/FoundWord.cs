using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;
using GrapeCity.Documents.Pdf;

namespace PDFSearch.BusinessLogic.Model
{
    public class FoundWord
    {
        public FoundPosition Position { get; set; }
        public string Word { get; set; }
    }

    public class Location
    {
        public int Page { get; set; }
        public int Line { get; set; }
    }
}
