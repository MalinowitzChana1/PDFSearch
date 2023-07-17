using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDFSearch.BusinessLogic;
using PDFSearch.BusinessLogic.Model;

namespace PDFSearch
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            txtFoundWords.Text = string.Empty;
        }

        private void btnUploadWordDocument_Click(object sender, EventArgs e)
        {
            string fileName = "";
            if (ofdUploadFile.ShowDialog() == DialogResult.OK)
            {
                fileName = ofdUploadFile.FileName;
            }

            SearchFile.AddWordsToSearch(fileName);
            var fileNameWithoutPath = System.IO.Path.GetFileName(ofdUploadFile.FileName);
            lblWordFileName.Text = fileNameWithoutPath;
        }

        private void btnUploadPdf_Click(object sender, EventArgs e)
        {
            ofdUploadFile.InitialDirectory = "..\\..\\..\\..\\SavedFiles";
            string fileName = "";
            if (ofdUploadFile.ShowDialog() == DialogResult.OK)
            {
                fileName = ofdUploadFile.FileName;
            }

            SearchFile.SaveFileName(fileName);
            var fileNameWithoutPath = System.IO.Path.GetFileName(ofdUploadFile.FileName);
            lblPDFName.Text = fileNameWithoutPath;
        }

        public void OutputFoundWords(List<FoundWord> foundWords)
        {
            foreach (var foundword in foundWords)
            {
                var locationString = $"{foundword.Word}: Page {foundword.Position?.PageIndex + 1}";
                txtFoundWords.Text = txtFoundWords.Text + locationString + Environment.NewLine;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var foundWords = SearchFile.ProcessPDFDocument();
            OutputFoundWords(foundWords);
        }
    }
}
