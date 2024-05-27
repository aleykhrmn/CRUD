namespace WindowsFormsApp1
{
    partial class DersAtama
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
            this.OgrenciIDLabel = new System.Windows.Forms.Label();
            this.OgrenciIDTextBox = new System.Windows.Forms.RichTextBox();
            this.DonemLabel = new System.Windows.Forms.Label();
            this.YariyilTextBox = new System.Windows.Forms.RichTextBox();
            this.YılLabel = new System.Windows.Forms.Label();
            this.YilTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DersIDTextBox = new System.Windows.Forms.RichTextBox();
            this.OnaylaButon = new System.Windows.Forms.Button();
            this.anasayfaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OgrenciIDLabel
            // 
            this.OgrenciIDLabel.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciIDLabel.Location = new System.Drawing.Point(235, 203);
            this.OgrenciIDLabel.Name = "OgrenciIDLabel";
            this.OgrenciIDLabel.Size = new System.Drawing.Size(147, 55);
            this.OgrenciIDLabel.TabIndex = 0;
            this.OgrenciIDLabel.Text = "Öğrenci ID";
            this.OgrenciIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciIDTextBox
            // 
            this.OgrenciIDTextBox.Location = new System.Drawing.Point(446, 203);
            this.OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            this.OgrenciIDTextBox.Size = new System.Drawing.Size(204, 55);
            this.OgrenciIDTextBox.TabIndex = 1;
            this.OgrenciIDTextBox.Text = "";
            // 
            // DonemLabel
            // 
            this.DonemLabel.BackColor = System.Drawing.Color.LightCoral;
            this.DonemLabel.Location = new System.Drawing.Point(235, 264);
            this.DonemLabel.Name = "DonemLabel";
            this.DonemLabel.Size = new System.Drawing.Size(147, 55);
            this.DonemLabel.TabIndex = 2;
            this.DonemLabel.Text = "Dönem";
            this.DonemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YariyilTextBox
            // 
            this.YariyilTextBox.Location = new System.Drawing.Point(446, 264);
            this.YariyilTextBox.Name = "YariyilTextBox";
            this.YariyilTextBox.Size = new System.Drawing.Size(204, 55);
            this.YariyilTextBox.TabIndex = 3;
            this.YariyilTextBox.Text = "";
            // 
            // YılLabel
            // 
            this.YılLabel.BackColor = System.Drawing.Color.LightCoral;
            this.YılLabel.Location = new System.Drawing.Point(235, 325);
            this.YılLabel.Name = "YılLabel";
            this.YılLabel.Size = new System.Drawing.Size(147, 55);
            this.YılLabel.TabIndex = 4;
            this.YılLabel.Text = "Yıl";
            this.YılLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YilTextBox
            // 
            this.YilTextBox.Location = new System.Drawing.Point(446, 325);
            this.YilTextBox.Name = "YilTextBox";
            this.YilTextBox.Size = new System.Drawing.Size(204, 55);
            this.YilTextBox.TabIndex = 5;
            this.YilTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(235, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ders ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersIDTextBox
            // 
            this.DersIDTextBox.Location = new System.Drawing.Point(446, 386);
            this.DersIDTextBox.Name = "DersIDTextBox";
            this.DersIDTextBox.Size = new System.Drawing.Size(204, 55);
            this.DersIDTextBox.TabIndex = 7;
            this.DersIDTextBox.Text = "";
            // 
            // OnaylaButon
            // 
            this.OnaylaButon.BackColor = System.Drawing.Color.IndianRed;
            this.OnaylaButon.Location = new System.Drawing.Point(525, 467);
            this.OnaylaButon.Name = "OnaylaButon";
            this.OnaylaButon.Size = new System.Drawing.Size(125, 54);
            this.OnaylaButon.TabIndex = 8;
            this.OnaylaButon.Text = "Onayla";
            this.OnaylaButon.UseVisualStyleBackColor = false;
            this.OnaylaButon.Click += new System.EventHandler(this.OnaylaButon_Click);
            // 
            // anasayfaLabel
            // 
            this.anasayfaLabel.BackColor = System.Drawing.Color.SeaShell;
            this.anasayfaLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaLabel.Location = new System.Drawing.Point(233, 30);
            this.anasayfaLabel.Name = "anasayfaLabel";
            this.anasayfaLabel.Size = new System.Drawing.Size(417, 138);
            this.anasayfaLabel.TabIndex = 24;
            this.anasayfaLabel.Text = "DERS KAYIT\r\nEKRANI";
            this.anasayfaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.anasayfaLabel);
            this.Controls.Add(this.OnaylaButon);
            this.Controls.Add(this.DersIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YilTextBox);
            this.Controls.Add(this.YılLabel);
            this.Controls.Add(this.YariyilTextBox);
            this.Controls.Add(this.DonemLabel);
            this.Controls.Add(this.OgrenciIDTextBox);
            this.Controls.Add(this.OgrenciIDLabel);
            this.Name = "DersAtama";
            this.Text = "DersAtama";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OgrenciIDLabel;
        private System.Windows.Forms.RichTextBox OgrenciIDTextBox;
        private System.Windows.Forms.Label DonemLabel;
        private System.Windows.Forms.RichTextBox YariyilTextBox;
        private System.Windows.Forms.Label YılLabel;
        private System.Windows.Forms.RichTextBox YilTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DersIDTextBox;
        private System.Windows.Forms.Button OnaylaButon;
        private System.Windows.Forms.Label anasayfaLabel;
    }
}