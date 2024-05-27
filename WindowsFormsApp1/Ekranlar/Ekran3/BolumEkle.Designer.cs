namespace WindowsFormsApp1
{
    partial class BolumEkle
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
            this.BolumAdiLabel = new System.Windows.Forms.Label();
            this.BolumAdiRichText = new System.Windows.Forms.RichTextBox();
            this.EkleButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FIDrichtext = new System.Windows.Forms.RichTextBox();
            this.BIDrichtext = new System.Windows.Forms.RichTextBox();
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BolumAdiLabel
            // 
            this.BolumAdiLabel.BackColor = System.Drawing.Color.LightCoral;
            this.BolumAdiLabel.Location = new System.Drawing.Point(201, 278);
            this.BolumAdiLabel.Name = "BolumAdiLabel";
            this.BolumAdiLabel.Size = new System.Drawing.Size(147, 61);
            this.BolumAdiLabel.TabIndex = 0;
            this.BolumAdiLabel.Text = "Bölüm Adı";
            this.BolumAdiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BolumAdiRichText
            // 
            this.BolumAdiRichText.Location = new System.Drawing.Point(429, 278);
            this.BolumAdiRichText.Name = "BolumAdiRichText";
            this.BolumAdiRichText.Size = new System.Drawing.Size(250, 61);
            this.BolumAdiRichText.TabIndex = 1;
            this.BolumAdiRichText.Text = "";
            // 
            // EkleButon
            // 
            this.EkleButon.BackColor = System.Drawing.Color.IndianRed;
            this.EkleButon.Location = new System.Drawing.Point(559, 442);
            this.EkleButon.Name = "EkleButon";
            this.EkleButon.Size = new System.Drawing.Size(120, 51);
            this.EkleButon.TabIndex = 2;
            this.EkleButon.Text = "Ekle";
            this.EkleButon.UseVisualStyleBackColor = false;
            this.EkleButon.Click += new System.EventHandler(this.EkleButon_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(201, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(201, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fakülte ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FIDrichtext
            // 
            this.FIDrichtext.Location = new System.Drawing.Point(429, 199);
            this.FIDrichtext.Name = "FIDrichtext";
            this.FIDrichtext.Size = new System.Drawing.Size(250, 61);
            this.FIDrichtext.TabIndex = 5;
            this.FIDrichtext.Text = "";
            // 
            // BIDrichtext
            // 
            this.BIDrichtext.Location = new System.Drawing.Point(429, 357);
            this.BIDrichtext.Name = "BIDrichtext";
            this.BIDrichtext.Size = new System.Drawing.Size(250, 61);
            this.BIDrichtext.TabIndex = 6;
            this.BIDrichtext.Text = "";
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(204, 40);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(475, 125);
            this.DersEkleLabel.TabIndex = 16;
            this.DersEkleLabel.Text = "BÖLÜM EKLE";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.BIDrichtext);
            this.Controls.Add(this.FIDrichtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EkleButon);
            this.Controls.Add(this.BolumAdiRichText);
            this.Controls.Add(this.BolumAdiLabel);
            this.Name = "BolumEkle";
            this.Text = "BolumEkle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BolumAdiLabel;
        private System.Windows.Forms.RichTextBox BolumAdiRichText;
        private System.Windows.Forms.Button EkleButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox FIDrichtext;
        private System.Windows.Forms.RichTextBox BIDrichtext;
        private System.Windows.Forms.Label DersEkleLabel;
    }
}