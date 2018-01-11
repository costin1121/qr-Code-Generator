namespace QR_Code_Generator
{
    partial class uMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uMain));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eCUMagister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eCUComerciant = new System.Windows.Forms.TextBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.bPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bSaveFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.eCUMagazin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(456, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Genereaza QR Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod Unic POS";
            // 
            // eCUMagister
            // 
            this.eCUMagister.Location = new System.Drawing.Point(456, 40);
            this.eCUMagister.Name = "eCUMagister";
            this.eCUMagister.Size = new System.Drawing.Size(260, 20);
            this.eCUMagister.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod Unic Comerciant";
            // 
            // eCUComerciant
            // 
            this.eCUComerciant.Location = new System.Drawing.Point(456, 123);
            this.eCUComerciant.Name = "eCUComerciant";
            this.eCUComerciant.Size = new System.Drawing.Size(260, 20);
            this.eCUComerciant.TabIndex = 5;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // bPrint
            // 
            this.bPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrint.Location = new System.Drawing.Point(583, 149);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(121, 23);
            this.bPrint.TabIndex = 6;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(29, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 302);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bSaveFile
            // 
            this.bSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveFile.Location = new System.Drawing.Point(105, 332);
            this.bSaveFile.Name = "bSaveFile";
            this.bSaveFile.Size = new System.Drawing.Size(121, 23);
            this.bSaveFile.TabIndex = 8;
            this.bSaveFile.Text = "Salveaza Qr Code";
            this.bSaveFile.UseVisualStyleBackColor = true;
            this.bSaveFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // eCUMagazin
            // 
            this.eCUMagazin.Location = new System.Drawing.Point(456, 84);
            this.eCUMagazin.Name = "eCUMagazin";
            this.eCUMagazin.Size = new System.Drawing.Size(260, 20);
            this.eCUMagazin.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cod Unic Magazin";
            // 
            // uMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(817, 495);
            this.Controls.Add(this.eCUMagazin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bSaveFile);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.eCUComerciant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eCUMagister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "uMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox eCUMagister;
        public System.Windows.Forms.TextBox eCUComerciant;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Button bSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        public System.Windows.Forms.TextBox eCUMagazin;
        private System.Windows.Forms.Label label3;
    }
}

