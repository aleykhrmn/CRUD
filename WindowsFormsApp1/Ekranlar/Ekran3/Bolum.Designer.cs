namespace WindowsFormsApp1
{
    partial class Bolum
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
            this.Bguncellestirmebuton = new System.Windows.Forms.Button();
            this.BsilButon = new System.Windows.Forms.Button();
            this.BlisteleButon = new System.Windows.Forms.Button();
            this.BekleButon = new System.Windows.Forms.Button();
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bguncellestirmebuton
            // 
            this.Bguncellestirmebuton.BackColor = System.Drawing.Color.LightCoral;
            this.Bguncellestirmebuton.Location = new System.Drawing.Point(460, 350);
            this.Bguncellestirmebuton.Name = "Bguncellestirmebuton";
            this.Bguncellestirmebuton.Size = new System.Drawing.Size(179, 76);
            this.Bguncellestirmebuton.TabIndex = 14;
            this.Bguncellestirmebuton.Text = "Güncelleştirme";
            this.Bguncellestirmebuton.UseVisualStyleBackColor = false;
            this.Bguncellestirmebuton.Click += new System.EventHandler(this.Bguncellestirmebuton_Click);
            // 
            // BsilButon
            // 
            this.BsilButon.BackColor = System.Drawing.Color.LightCoral;
            this.BsilButon.Location = new System.Drawing.Point(460, 251);
            this.BsilButon.Name = "BsilButon";
            this.BsilButon.Size = new System.Drawing.Size(179, 76);
            this.BsilButon.TabIndex = 13;
            this.BsilButon.Text = "Sil";
            this.BsilButon.UseVisualStyleBackColor = false;
            this.BsilButon.Click += new System.EventHandler(this.BsilButon_Click);
            // 
            // BlisteleButon
            // 
            this.BlisteleButon.BackColor = System.Drawing.Color.LightCoral;
            this.BlisteleButon.Location = new System.Drawing.Point(243, 350);
            this.BlisteleButon.Name = "BlisteleButon";
            this.BlisteleButon.Size = new System.Drawing.Size(179, 76);
            this.BlisteleButon.TabIndex = 12;
            this.BlisteleButon.Text = "Listele";
            this.BlisteleButon.UseVisualStyleBackColor = false;
            this.BlisteleButon.Click += new System.EventHandler(this.BlisteleButon_Click);
            // 
            // BekleButon
            // 
            this.BekleButon.BackColor = System.Drawing.Color.LightCoral;
            this.BekleButon.Location = new System.Drawing.Point(243, 251);
            this.BekleButon.Name = "BekleButon";
            this.BekleButon.Size = new System.Drawing.Size(179, 76);
            this.BekleButon.TabIndex = 11;
            this.BekleButon.Text = "Ekle";
            this.BekleButon.UseVisualStyleBackColor = false;
            this.BekleButon.Click += new System.EventHandler(this.BekleButon_Click);
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(243, 73);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(396, 136);
            this.DersEkleLabel.TabIndex = 15;
            this.DersEkleLabel.Text = "BÖLÜM CRUD";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.Bguncellestirmebuton);
            this.Controls.Add(this.BsilButon);
            this.Controls.Add(this.BlisteleButon);
            this.Controls.Add(this.BekleButon);
            this.Name = "Bolum";
            this.Text = "Bolum";
            this.Load += new System.EventHandler(this.Bolum_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bguncellestirmebuton;
        private System.Windows.Forms.Button BsilButon;
        private System.Windows.Forms.Button BlisteleButon;
        private System.Windows.Forms.Button BekleButon;
        private System.Windows.Forms.Label DersEkleLabel;
    }
}