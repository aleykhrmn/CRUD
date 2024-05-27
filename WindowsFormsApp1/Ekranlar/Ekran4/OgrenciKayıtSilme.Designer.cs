namespace WindowsFormsApp1
{
    partial class OgrenciKayıtSilme
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
            this.OnaylaButon = new System.Windows.Forms.Button();
            this.DersIDTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YilTextBox = new System.Windows.Forms.RichTextBox();
            this.YılLabel = new System.Windows.Forms.Label();
            this.YariyilTextBox = new System.Windows.Forms.RichTextBox();
            this.DonemLabel = new System.Windows.Forms.Label();
            this.OgrenciIDTextBox = new System.Windows.Forms.RichTextBox();
            this.OgrenciIDLabel = new System.Windows.Forms.Label();
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OnaylaButon
            // 
            this.OnaylaButon.BackColor = System.Drawing.Color.IndianRed;
            this.OnaylaButon.Location = new System.Drawing.Point(531, 463);
            this.OnaylaButon.Name = "OnaylaButon";
            this.OnaylaButon.Size = new System.Drawing.Size(128, 55);
            this.OnaylaButon.TabIndex = 17;
            this.OnaylaButon.Text = "Onayla";
            this.OnaylaButon.UseVisualStyleBackColor = false;
            this.OnaylaButon.Click += new System.EventHandler(this.OnaylaButon_Click);
            // 
            // DersIDTextBox
            // 
            this.DersIDTextBox.Location = new System.Drawing.Point(448, 382);
            this.DersIDTextBox.Name = "DersIDTextBox";
            this.DersIDTextBox.Size = new System.Drawing.Size(211, 63);
            this.DersIDTextBox.TabIndex = 16;
            this.DersIDTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(233, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 63);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ders ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YilTextBox
            // 
            this.YilTextBox.Location = new System.Drawing.Point(448, 313);
            this.YilTextBox.Name = "YilTextBox";
            this.YilTextBox.Size = new System.Drawing.Size(211, 63);
            this.YilTextBox.TabIndex = 14;
            this.YilTextBox.Text = "";
            // 
            // YılLabel
            // 
            this.YılLabel.BackColor = System.Drawing.Color.LightCoral;
            this.YılLabel.Location = new System.Drawing.Point(233, 313);
            this.YılLabel.Name = "YılLabel";
            this.YılLabel.Size = new System.Drawing.Size(149, 63);
            this.YılLabel.TabIndex = 13;
            this.YılLabel.Text = "Yıl";
            this.YılLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YariyilTextBox
            // 
            this.YariyilTextBox.Location = new System.Drawing.Point(448, 244);
            this.YariyilTextBox.Name = "YariyilTextBox";
            this.YariyilTextBox.Size = new System.Drawing.Size(211, 63);
            this.YariyilTextBox.TabIndex = 12;
            this.YariyilTextBox.Text = "";
            // 
            // DonemLabel
            // 
            this.DonemLabel.BackColor = System.Drawing.Color.LightCoral;
            this.DonemLabel.Location = new System.Drawing.Point(233, 244);
            this.DonemLabel.Name = "DonemLabel";
            this.DonemLabel.Size = new System.Drawing.Size(149, 63);
            this.DonemLabel.TabIndex = 11;
            this.DonemLabel.Text = "Dönem";
            this.DonemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciIDTextBox
            // 
            this.OgrenciIDTextBox.Location = new System.Drawing.Point(448, 175);
            this.OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            this.OgrenciIDTextBox.Size = new System.Drawing.Size(211, 63);
            this.OgrenciIDTextBox.TabIndex = 10;
            this.OgrenciIDTextBox.Text = "";
            // 
            // OgrenciIDLabel
            // 
            this.OgrenciIDLabel.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciIDLabel.Location = new System.Drawing.Point(233, 175);
            this.OgrenciIDLabel.Name = "OgrenciIDLabel";
            this.OgrenciIDLabel.Size = new System.Drawing.Size(149, 63);
            this.OgrenciIDLabel.TabIndex = 9;
            this.OgrenciIDLabel.Text = "Öğrenci ID";
            this.OgrenciIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(231, 21);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(428, 140);
            this.DersEkleLabel.TabIndex = 18;
            this.DersEkleLabel.Text = "ÖĞRENCİ DERS \r\nSİLME";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DersEkleLabel.Click += new System.EventHandler(this.DersEkleLabel_Click);
            // 
            // OgrenciKayıtSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.OnaylaButon);
            this.Controls.Add(this.DersIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YilTextBox);
            this.Controls.Add(this.YılLabel);
            this.Controls.Add(this.YariyilTextBox);
            this.Controls.Add(this.DonemLabel);
            this.Controls.Add(this.OgrenciIDTextBox);
            this.Controls.Add(this.OgrenciIDLabel);
            this.Name = "OgrenciKayıtSilme";
            this.Text = "OgrenciKayıtSilme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OnaylaButon;
        private System.Windows.Forms.RichTextBox DersIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox YilTextBox;
        private System.Windows.Forms.Label YılLabel;
        private System.Windows.Forms.RichTextBox YariyilTextBox;
        private System.Windows.Forms.Label DonemLabel;
        private System.Windows.Forms.RichTextBox OgrenciIDTextBox;
        private System.Windows.Forms.Label OgrenciIDLabel;
        private System.Windows.Forms.Label DersEkleLabel;
    }
}