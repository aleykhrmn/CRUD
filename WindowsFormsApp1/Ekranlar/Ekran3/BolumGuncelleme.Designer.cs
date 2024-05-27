namespace WindowsFormsApp1
{
    partial class BolumGuncelleme
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
            this.BolumIDTextBox = new System.Windows.Forms.RichTextBox();
            this.FakulteIDTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GüncelleButon = new System.Windows.Forms.Button();
            this.BolumAdiTextBox = new System.Windows.Forms.RichTextBox();
            this.BolumAdiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(220, 38);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(452, 124);
            this.DersEkleLabel.TabIndex = 32;
            this.DersEkleLabel.Text = "BÖLÜM GÜNCELLEME";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BolumIDTextBox
            // 
            this.BolumIDTextBox.Location = new System.Drawing.Point(425, 349);
            this.BolumIDTextBox.Name = "BolumIDTextBox";
            this.BolumIDTextBox.Size = new System.Drawing.Size(247, 58);
            this.BolumIDTextBox.TabIndex = 31;
            this.BolumIDTextBox.Text = "";
            // 
            // FakulteIDTextBox
            // 
            this.FakulteIDTextBox.Location = new System.Drawing.Point(425, 189);
            this.FakulteIDTextBox.Name = "FakulteIDTextBox";
            this.FakulteIDTextBox.Size = new System.Drawing.Size(247, 58);
            this.FakulteIDTextBox.TabIndex = 30;
            this.FakulteIDTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(222, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 58);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fakülte ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(222, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 58);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bölüm ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GüncelleButon
            // 
            this.GüncelleButon.BackColor = System.Drawing.Color.IndianRed;
            this.GüncelleButon.Location = new System.Drawing.Point(547, 437);
            this.GüncelleButon.Name = "GüncelleButon";
            this.GüncelleButon.Size = new System.Drawing.Size(125, 52);
            this.GüncelleButon.TabIndex = 27;
            this.GüncelleButon.Text = "Güncelle";
            this.GüncelleButon.UseVisualStyleBackColor = false;
            this.GüncelleButon.Click += new System.EventHandler(this.GüncelleButon_Click);
            // 
            // BolumAdiTextBox
            // 
            this.BolumAdiTextBox.Location = new System.Drawing.Point(425, 266);
            this.BolumAdiTextBox.Name = "BolumAdiTextBox";
            this.BolumAdiTextBox.Size = new System.Drawing.Size(247, 56);
            this.BolumAdiTextBox.TabIndex = 26;
            this.BolumAdiTextBox.Text = "";
            // 
            // BolumAdiLabel
            // 
            this.BolumAdiLabel.BackColor = System.Drawing.Color.LightCoral;
            this.BolumAdiLabel.Location = new System.Drawing.Point(222, 266);
            this.BolumAdiLabel.Name = "BolumAdiLabel";
            this.BolumAdiLabel.Size = new System.Drawing.Size(138, 58);
            this.BolumAdiLabel.TabIndex = 25;
            this.BolumAdiLabel.Text = "Bölüm Adı";
            this.BolumAdiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.BolumIDTextBox);
            this.Controls.Add(this.FakulteIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GüncelleButon);
            this.Controls.Add(this.BolumAdiTextBox);
            this.Controls.Add(this.BolumAdiLabel);
            this.Name = "BG";
            this.Text = "BG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DersEkleLabel;
        private System.Windows.Forms.RichTextBox BolumIDTextBox;
        private System.Windows.Forms.RichTextBox FakulteIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GüncelleButon;
        private System.Windows.Forms.RichTextBox BolumAdiTextBox;
        private System.Windows.Forms.Label BolumAdiLabel;
    }
}