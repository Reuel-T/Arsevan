
namespace Arsevan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.fdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.rtbFile = new System.Windows.Forms.RichTextBox();
            this.btnCheckBrackets = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.btnConvertNumber = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(46, 51);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "Movie Title";
            this.txtTitle.Size = new System.Drawing.Size(221, 27);
            this.txtTitle.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 51);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstMovies
            // 
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.ItemHeight = 20;
            this.lstMovies.Location = new System.Drawing.Point(46, 103);
            this.lstMovies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(301, 324);
            this.lstMovies.TabIndex = 2;
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(46, 453);
            this.btnPop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(135, 31);
            this.btnPop.TabIndex = 3;
            this.btnPop.Text = "Watched";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(213, 453);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 31);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Show Next Movie";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(46, 507);
            this.btnPopulate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(302, 31);
            this.btnPopulate.TabIndex = 5;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // fdFile
            // 
            this.fdFile.FileName = "never gonna give you up";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(414, 51);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(86, 31);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // rtbFile
            // 
            this.rtbFile.Location = new System.Drawing.Point(414, 103);
            this.rtbFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbFile.Name = "rtbFile";
            this.rtbFile.Size = new System.Drawing.Size(419, 433);
            this.rtbFile.TabIndex = 7;
            this.rtbFile.Text = "";
            // 
            // btnCheckBrackets
            // 
            this.btnCheckBrackets.Location = new System.Drawing.Point(546, 51);
            this.btnCheckBrackets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckBrackets.Name = "btnCheckBrackets";
            this.btnCheckBrackets.Size = new System.Drawing.Size(154, 31);
            this.btnCheckBrackets.TabIndex = 8;
            this.btnCheckBrackets.Text = "Check Parenthesis";
            this.btnCheckBrackets.UseVisualStyleBackColor = true;
            this.btnCheckBrackets.Click += new System.EventHandler(this.btnCheckBrackets_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(46, 570);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(787, 215);
            this.rtbOutput.TabIndex = 9;
            this.rtbOutput.Text = "";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(899, 51);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PlaceholderText = "Number";
            this.txtNumber.Size = new System.Drawing.Size(221, 27);
            this.txtNumber.TabIndex = 11;
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(899, 103);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(374, 27);
            this.txtBinary.TabIndex = 12;
            // 
            // btnConvertNumber
            // 
            this.btnConvertNumber.Location = new System.Drawing.Point(1147, 51);
            this.btnConvertNumber.Name = "btnConvertNumber";
            this.btnConvertNumber.Size = new System.Drawing.Size(126, 29);
            this.btnConvertNumber.TabIndex = 13;
            this.btnConvertNumber.Text = "Conv To Binary";
            this.btnConvertNumber.UseVisualStyleBackColor = true;
            this.btnConvertNumber.Click += new System.EventHandler(this.btnConvertNumber_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(899, 197);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(374, 27);
            this.txtString.TabIndex = 14;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(899, 231);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(94, 29);
            this.btnParse.TabIndex = 15;
            this.btnParse.Text = "button1";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 815);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnConvertNumber);
            this.Controls.Add(this.txtBinary);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnCheckBrackets);
            this.Controls.Add(this.rtbFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.lstMovies);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.OpenFileDialog fdFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RichTextBox rtbFile;
        private System.Windows.Forms.Button btnCheckBrackets;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.Button btnConvertNumber;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnParse;
    }
}

