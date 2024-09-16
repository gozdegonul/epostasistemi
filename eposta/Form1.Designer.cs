namespace eposta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.pBarama = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lblgelen = new System.Windows.Forms.Label();
            this.panelveri = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelgelen = new System.Windows.Forms.Panel();
            this.panelgiden = new System.Windows.Forms.Panel();
            this.lblgiden = new System.Windows.Forms.Label();
            this.lbleposta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBarama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.panelveri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelgelen.SuspendLayout();
            this.panelgiden.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pb1);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "EasyMail";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 9);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 65);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.txtarama);
            this.panel2.Controls.Add(this.pBarama);
            this.panel2.Location = new System.Drawing.Point(258, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 69);
            this.panel2.TabIndex = 3;
            // 
            // txtarama
            // 
            this.txtarama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarama.ForeColor = System.Drawing.Color.Gray;
            this.txtarama.Location = new System.Drawing.Point(16, 17);
            this.txtarama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(552, 34);
            this.txtarama.TabIndex = 5;
            this.txtarama.Text = "E-Posta ara";
            // 
            // pBarama
            // 
            this.pBarama.Image = ((System.Drawing.Image)(resources.GetObject("pBarama.Image")));
            this.pBarama.Location = new System.Drawing.Point(574, 10);
            this.pBarama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBarama.Name = "pBarama";
            this.pBarama.Size = new System.Drawing.Size(52, 52);
            this.pBarama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBarama.TabIndex = 4;
            this.pBarama.TabStop = false;
            this.pBarama.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(939, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1034, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pb1
            // 
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(1123, 15);
            this.pb1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(74, 52);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // lblgelen
            // 
            this.lblgelen.AutoSize = true;
            this.lblgelen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblgelen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgelen.Location = new System.Drawing.Point(14, 22);
            this.lblgelen.Name = "lblgelen";
            this.lblgelen.Size = new System.Drawing.Size(120, 28);
            this.lblgelen.TabIndex = 1;
            this.lblgelen.Text = "Gelen Posta";
            this.lblgelen.Click += new System.EventHandler(this.lblgelen_Click);
            // 
            // panelveri
            // 
            this.panelveri.BackColor = System.Drawing.Color.Azure;
            this.panelveri.Controls.Add(this.pictureBox6);
            this.panelveri.Controls.Add(this.dataGridView1);
            this.panelveri.Location = new System.Drawing.Point(26, 156);
            this.panelveri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelveri.Name = "panelveri";
            this.panelveri.Size = new System.Drawing.Size(1185, 551);
            this.panelveri.TabIndex = 3;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1106, 482);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(65, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelgelen
            // 
            this.panelgelen.BackColor = System.Drawing.Color.Azure;
            this.panelgelen.Controls.Add(this.lblgelen);
            this.panelgelen.Location = new System.Drawing.Point(26, 95);
            this.panelgelen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelgelen.Name = "panelgelen";
            this.panelgelen.Size = new System.Drawing.Size(152, 64);
            this.panelgelen.TabIndex = 4;
            // 
            // panelgiden
            // 
            this.panelgiden.BackColor = System.Drawing.Color.Azure;
            this.panelgiden.Controls.Add(this.lblgiden);
            this.panelgiden.Location = new System.Drawing.Point(177, 95);
            this.panelgiden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelgiden.Name = "panelgiden";
            this.panelgiden.Size = new System.Drawing.Size(152, 64);
            this.panelgiden.TabIndex = 5;
            // 
            // lblgiden
            // 
            this.lblgiden.AutoSize = true;
            this.lblgiden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblgiden.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgiden.ForeColor = System.Drawing.Color.Gray;
            this.lblgiden.Location = new System.Drawing.Point(13, 22);
            this.lblgiden.Name = "lblgiden";
            this.lblgiden.Size = new System.Drawing.Size(121, 28);
            this.lblgiden.TabIndex = 2;
            this.lblgiden.Text = "Giden Posta";
            this.lblgiden.Click += new System.EventHandler(this.lblgiden_Click);
            // 
            // lbleposta
            // 
            this.lbleposta.AutoSize = true;
            this.lbleposta.Location = new System.Drawing.Point(896, 109);
            this.lbleposta.Name = "lbleposta";
            this.lbleposta.Size = new System.Drawing.Size(50, 20);
            this.lbleposta.TabIndex = 6;
            this.lbleposta.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1224, 718);
            this.Controls.Add(this.lbleposta);
            this.Controls.Add(this.panelgiden);
            this.Controls.Add(this.panelgelen);
            this.Controls.Add(this.panelveri);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBarama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.panelveri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelgelen.ResumeLayout(false);
            this.panelgelen.PerformLayout();
            this.panelgiden.ResumeLayout(false);
            this.panelgiden.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.PictureBox pBarama;
        private System.Windows.Forms.Label lblgelen;
        private System.Windows.Forms.Panel panelveri;
        private System.Windows.Forms.Panel panelgelen;
        private System.Windows.Forms.Panel panelgiden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblgiden;
        private System.Windows.Forms.Label lbleposta;
    }
}

