namespace WindowsFormsApp1
{
    partial class FakulteEkle
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
            this.FakulteAdı = new System.Windows.Forms.RichTextBox();
            this.FakulteAdi = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.FakulteIDLAbel = new System.Windows.Forms.Label();
            this.FakulteIDRichText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FakulteAdı
            // 
            this.FakulteAdı.BackColor = System.Drawing.SystemColors.HighlightText;
            this.FakulteAdı.Location = new System.Drawing.Point(355, 177);
            this.FakulteAdı.Name = "FakulteAdı";
            this.FakulteAdı.Size = new System.Drawing.Size(215, 50);
            this.FakulteAdı.TabIndex = 0;
            this.FakulteAdı.Text = "";
            // 
            // FakulteAdi
            // 
            this.FakulteAdi.BackColor = System.Drawing.Color.LightCoral;
            this.FakulteAdi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FakulteAdi.Location = new System.Drawing.Point(173, 177);
            this.FakulteAdi.Name = "FakulteAdi";
            this.FakulteAdi.Size = new System.Drawing.Size(123, 50);
            this.FakulteAdi.TabIndex = 1;
            this.FakulteAdi.Text = "Fakülte Adı";
            this.FakulteAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FakulteAdi.Click += new System.EventHandler(this.FakulteAdi_Click);
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.Color.IndianRed;
            this.Ekle.Location = new System.Drawing.Point(477, 260);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(93, 45);
            this.Ekle.TabIndex = 2;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.UseWaitCursor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // FakulteIDLAbel
            // 
            this.FakulteIDLAbel.BackColor = System.Drawing.Color.LightCoral;
            this.FakulteIDLAbel.Location = new System.Drawing.Point(169, 100);
            this.FakulteIDLAbel.Name = "FakulteIDLAbel";
            this.FakulteIDLAbel.Size = new System.Drawing.Size(127, 50);
            this.FakulteIDLAbel.TabIndex = 3;
            this.FakulteIDLAbel.Text = "Fakülte ID";
            this.FakulteIDLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FakulteIDRichText
            // 
            this.FakulteIDRichText.Location = new System.Drawing.Point(355, 103);
            this.FakulteIDRichText.Name = "FakulteIDRichText";
            this.FakulteIDRichText.Size = new System.Drawing.Size(215, 47);
            this.FakulteIDRichText.TabIndex = 4;
            this.FakulteIDRichText.Text = "";
            // 
            // FakulteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.FakulteIDRichText);
            this.Controls.Add(this.FakulteIDLAbel);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.FakulteAdi);
            this.Controls.Add(this.FakulteAdı);
            this.Name = "FakulteEkle";
            this.Text = "FakulteEkle1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox FakulteAdı;
        private System.Windows.Forms.Label FakulteAdi;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Label FakulteIDLAbel;
        private System.Windows.Forms.RichTextBox FakulteIDRichText;
    }
}