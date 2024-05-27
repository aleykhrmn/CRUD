namespace WindowsFormsApp1
{
    partial class DersGuncelleme
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
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.DersIDTextBox = new System.Windows.Forms.RichTextBox();
            this.DersIDLabel = new System.Windows.Forms.Label();
            this.Güncelleme = new System.Windows.Forms.Button();
            this.DersAdiTextBox = new System.Windows.Forms.RichTextBox();
            this.DersAdiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(204, 63);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(458, 125);
            this.DersEkleLabel.TabIndex = 11;
            this.DersEkleLabel.Text = "DERS GÜNCELLEME";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersIDTextBox
            // 
            this.DersIDTextBox.Location = new System.Drawing.Point(429, 326);
            this.DersIDTextBox.Name = "DersIDTextBox";
            this.DersIDTextBox.Size = new System.Drawing.Size(233, 64);
            this.DersIDTextBox.TabIndex = 10;
            this.DersIDTextBox.Text = "";
            // 
            // DersIDLabel
            // 
            this.DersIDLabel.BackColor = System.Drawing.Color.LightCoral;
            this.DersIDLabel.Location = new System.Drawing.Point(206, 326);
            this.DersIDLabel.Name = "DersIDLabel";
            this.DersIDLabel.Size = new System.Drawing.Size(177, 64);
            this.DersIDLabel.TabIndex = 9;
            this.DersIDLabel.Text = "Ders ID";
            this.DersIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Güncelleme
            // 
            this.Güncelleme.BackColor = System.Drawing.Color.IndianRed;
            this.Güncelleme.Location = new System.Drawing.Point(535, 421);
            this.Güncelleme.Name = "Güncelleme";
            this.Güncelleme.Size = new System.Drawing.Size(127, 56);
            this.Güncelleme.TabIndex = 8;
            this.Güncelleme.Text = "Güncelleme";
            this.Güncelleme.UseVisualStyleBackColor = false;
            this.Güncelleme.Click += new System.EventHandler(this.Güncelleme_Click);
            // 
            // DersAdiTextBox
            // 
            this.DersAdiTextBox.Location = new System.Drawing.Point(429, 238);
            this.DersAdiTextBox.Name = "DersAdiTextBox";
            this.DersAdiTextBox.Size = new System.Drawing.Size(233, 64);
            this.DersAdiTextBox.TabIndex = 7;
            this.DersAdiTextBox.Text = "";
            // 
            // DersAdiLabel
            // 
            this.DersAdiLabel.BackColor = System.Drawing.Color.LightCoral;
            this.DersAdiLabel.Location = new System.Drawing.Point(206, 238);
            this.DersAdiLabel.Name = "DersAdiLabel";
            this.DersAdiLabel.Size = new System.Drawing.Size(180, 64);
            this.DersAdiLabel.TabIndex = 6;
            this.DersAdiLabel.Text = "Ders Adı";
            this.DersAdiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.DersIDTextBox);
            this.Controls.Add(this.DersIDLabel);
            this.Controls.Add(this.Güncelleme);
            this.Controls.Add(this.DersAdiTextBox);
            this.Controls.Add(this.DersAdiLabel);
            this.Name = "DersGuncelleme";
            this.Text = "DersGuncelleme";
            this.Load += new System.EventHandler(this.DersGuncelleme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DersEkleLabel;
        private System.Windows.Forms.RichTextBox DersIDTextBox;
        private System.Windows.Forms.Label DersIDLabel;
        private System.Windows.Forms.Button Güncelleme;
        private System.Windows.Forms.RichTextBox DersAdiTextBox;
        private System.Windows.Forms.Label DersAdiLabel;
    }
}