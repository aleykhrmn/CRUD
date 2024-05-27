namespace WindowsFormsApp1
{
    partial class DersEkle
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
            this.Ekle = new System.Windows.Forms.Button();
            this.DersAdTextBox = new System.Windows.Forms.RichTextBox();
            this.DersAdiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(218, 74);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(447, 117);
            this.DersEkleLabel.TabIndex = 11;
            this.DersEkleLabel.Text = "DERS EKLE";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersIDTextBox
            // 
            this.DersIDTextBox.Location = new System.Drawing.Point(454, 336);
            this.DersIDTextBox.Name = "DersIDTextBox";
            this.DersIDTextBox.Size = new System.Drawing.Size(211, 59);
            this.DersIDTextBox.TabIndex = 10;
            this.DersIDTextBox.Text = "";
            // 
            // DersIDLabel
            // 
            this.DersIDLabel.BackColor = System.Drawing.Color.LightCoral;
            this.DersIDLabel.Location = new System.Drawing.Point(220, 336);
            this.DersIDLabel.Name = "DersIDLabel";
            this.DersIDLabel.Size = new System.Drawing.Size(169, 59);
            this.DersIDLabel.TabIndex = 9;
            this.DersIDLabel.Text = "Ders ID";
            this.DersIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.Color.IndianRed;
            this.Ekle.Location = new System.Drawing.Point(548, 427);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(117, 52);
            this.Ekle.TabIndex = 8;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // DersAdTextBox
            // 
            this.DersAdTextBox.Location = new System.Drawing.Point(454, 252);
            this.DersAdTextBox.Name = "DersAdTextBox";
            this.DersAdTextBox.Size = new System.Drawing.Size(211, 59);
            this.DersAdTextBox.TabIndex = 7;
            this.DersAdTextBox.Text = "";
            // 
            // DersAdiLabel
            // 
            this.DersAdiLabel.BackColor = System.Drawing.Color.LightCoral;
            this.DersAdiLabel.Location = new System.Drawing.Point(220, 252);
            this.DersAdiLabel.Name = "DersAdiLabel";
            this.DersAdiLabel.Size = new System.Drawing.Size(172, 59);
            this.DersAdiLabel.TabIndex = 6;
            this.DersAdiLabel.Text = "Ders Adı";
            this.DersAdiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.DersIDTextBox);
            this.Controls.Add(this.DersIDLabel);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.DersAdTextBox);
            this.Controls.Add(this.DersAdiLabel);
            this.Name = "DEkle";
            this.Text = "DEkle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DersEkleLabel;
        private System.Windows.Forms.RichTextBox DersIDTextBox;
        private System.Windows.Forms.Label DersIDLabel;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.RichTextBox DersAdTextBox;
        private System.Windows.Forms.Label DersAdiLabel;
    }
}