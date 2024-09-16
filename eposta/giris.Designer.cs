namespace eposta
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblgiris = new System.Windows.Forms.Label();
            this.lblhesap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblhesap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(39, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 453);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.lblgiris);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(717, 375);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(72, 49);
            this.panel5.TabIndex = 1;
            // 
            // lblgiris
            // 
            this.lblgiris.AutoSize = true;
            this.lblgiris.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgiris.ForeColor = System.Drawing.Color.Transparent;
            this.lblgiris.Location = new System.Drawing.Point(9, 10);
            this.lblgiris.Name = "lblgiris";
            this.lblgiris.Size = new System.Drawing.Size(52, 28);
            this.lblgiris.TabIndex = 9;
            this.lblgiris.Text = "Giriş";
            this.lblgiris.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblhesap
            // 
            this.lblhesap.AutoSize = true;
            this.lblhesap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblhesap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhesap.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblhesap.Location = new System.Drawing.Point(531, 385);
            this.lblhesap.Name = "lblhesap";
            this.lblhesap.Size = new System.Drawing.Size(166, 28);
            this.lblhesap.TabIndex = 10;
            this.lblhesap.Text = "Hesap Oluşturun";
            this.lblhesap.Click += new System.EventHandler(this.lblhesap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oturum Açın";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(230, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 200);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.txtsifre);
            this.panel4.Location = new System.Drawing.Point(19, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 86);
            this.panel4.TabIndex = 1;
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.ForeColor = System.Drawing.Color.Gray;
            this.txtsifre.Location = new System.Drawing.Point(6, 27);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(493, 34);
            this.txtsifre.TabIndex = 1;
            this.txtsifre.Text = "Şifre";
            this.txtsifre.Click += new System.EventHandler(this.txtsifre_Click);
            this.txtsifre.TextChanged += new System.EventHandler(this.txtsifre_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.txteposta);
            this.panel3.Location = new System.Drawing.Point(19, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 88);
            this.panel3.TabIndex = 0;
            // 
            // txteposta
            // 
            this.txteposta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteposta.ForeColor = System.Drawing.Color.Gray;
            this.txteposta.Location = new System.Drawing.Point(6, 14);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(493, 34);
            this.txteposta.TabIndex = 0;
            this.txteposta.Text = "E-Posta";
            this.txteposta.Click += new System.EventHandler(this.txteposta_Click);
            this.txteposta.TextChanged += new System.EventHandler(this.txteposta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(95, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "EasyMail";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(31, 147);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 525);
            this.Controls.Add(this.panel1);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhesap;
        private System.Windows.Forms.Label lblgiris;
        private System.Windows.Forms.Panel panel5;
    }
}