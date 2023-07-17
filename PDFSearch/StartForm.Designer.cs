namespace PDFSearch
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadWordDocument = new System.Windows.Forms.Button();
            this.btnUploadPdf = new System.Windows.Forms.Button();
            this.txtFoundWords = new System.Windows.Forms.TextBox();
            this.lblWordFileName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdUploadFile
            // 
            this.ofdUploadFile.FileName = "openFileDialog1";
            // 
            // btnUploadWordDocument
            // 
            this.btnUploadWordDocument.Location = new System.Drawing.Point(139, 53);
            this.btnUploadWordDocument.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadWordDocument.Name = "btnUploadWordDocument";
            this.btnUploadWordDocument.Size = new System.Drawing.Size(158, 72);
            this.btnUploadWordDocument.TabIndex = 0;
            this.btnUploadWordDocument.Text = "Upload band words";
            this.btnUploadWordDocument.UseVisualStyleBackColor = true;
            this.btnUploadWordDocument.Click += new System.EventHandler(this.btnUploadWordDocument_Click);
            // 
            // btnUploadPdf
            // 
            this.btnUploadPdf.Location = new System.Drawing.Point(370, 53);
            this.btnUploadPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadPdf.Name = "btnUploadPdf";
            this.btnUploadPdf.Size = new System.Drawing.Size(158, 72);
            this.btnUploadPdf.TabIndex = 1;
            this.btnUploadPdf.Text = "Upload PDF file";
            this.btnUploadPdf.UseVisualStyleBackColor = true;
            this.btnUploadPdf.Click += new System.EventHandler(this.btnUploadPdf_Click);
            // 
            // txtFoundWords
            // 
            this.txtFoundWords.Location = new System.Drawing.Point(592, 53);
            this.txtFoundWords.Multiline = true;
            this.txtFoundWords.Name = "txtFoundWords";
            this.txtFoundWords.Size = new System.Drawing.Size(400, 416);
            this.txtFoundWords.TabIndex = 2;
            // 
            // lblWordFileName
            // 
            this.lblWordFileName.AutoSize = true;
            this.lblWordFileName.Location = new System.Drawing.Point(172, 135);
            this.lblWordFileName.Name = "lblWordFileName";
            this.lblWordFileName.Size = new System.Drawing.Size(0, 15);
            this.lblWordFileName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(168, 294);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(282, 56);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search File";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 515);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblWordFileName);
            this.Controls.Add(this.txtFoundWords);
            this.Controls.Add(this.btnUploadPdf);
            this.Controls.Add(this.btnUploadWordDocument);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog ofdUploadFile;
        private Button btnUploadWordDocument;
        private Button btnUploadPdf;
        private TextBox txtFoundWords;
        private Label lblWordFileName;
        private Button btnSearch;
    }
}