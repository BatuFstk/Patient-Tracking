namespace Patient_Tracking
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Kayıttckimliktext = new System.Windows.Forms.TextBox();
            this.DoktorAdi = new System.Windows.Forms.TextBox();
            this.DoktorSoyadi = new System.Windows.Forms.TextBox();
            this.Kayıtsifretext = new System.Windows.Forms.TextBox();
            this.backtologinbutton = new System.Windows.Forms.Button();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 109);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA BASINÇ TAKİP OTOMASYONU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(234, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC KİMLİK NO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(280, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "ADINIZ : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(253, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "SOYADINIZ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(294, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "ŞİFRE : ";
            // 
            // Kayıttckimliktext
            // 
            this.Kayıttckimliktext.BackColor = System.Drawing.Color.White;
            this.Kayıttckimliktext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayıttckimliktext.Location = new System.Drawing.Point(358, 237);
            this.Kayıttckimliktext.Multiline = true;
            this.Kayıttckimliktext.Name = "Kayıttckimliktext";
            this.Kayıttckimliktext.Size = new System.Drawing.Size(288, 33);
            this.Kayıttckimliktext.TabIndex = 6;
            this.Kayıttckimliktext.TextChanged += new System.EventHandler(this.Kayıttckimliktext_TextChanged);
            // 
            // DoktorAdi
            // 
            this.DoktorAdi.BackColor = System.Drawing.Color.White;
            this.DoktorAdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoktorAdi.Location = new System.Drawing.Point(358, 291);
            this.DoktorAdi.Multiline = true;
            this.DoktorAdi.Name = "DoktorAdi";
            this.DoktorAdi.Size = new System.Drawing.Size(288, 33);
            this.DoktorAdi.TabIndex = 7;
            // 
            // DoktorSoyadi
            // 
            this.DoktorSoyadi.BackColor = System.Drawing.Color.White;
            this.DoktorSoyadi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoktorSoyadi.Location = new System.Drawing.Point(358, 350);
            this.DoktorSoyadi.Multiline = true;
            this.DoktorSoyadi.Name = "DoktorSoyadi";
            this.DoktorSoyadi.Size = new System.Drawing.Size(288, 33);
            this.DoktorSoyadi.TabIndex = 8;
            // 
            // Kayıtsifretext
            // 
            this.Kayıtsifretext.BackColor = System.Drawing.Color.White;
            this.Kayıtsifretext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayıtsifretext.Location = new System.Drawing.Point(358, 409);
            this.Kayıtsifretext.Multiline = true;
            this.Kayıtsifretext.Name = "Kayıtsifretext";
            this.Kayıtsifretext.PasswordChar = '*';
            this.Kayıtsifretext.Size = new System.Drawing.Size(288, 33);
            this.Kayıtsifretext.TabIndex = 9;
            // 
            // backtologinbutton
            // 
            this.backtologinbutton.BackColor = System.Drawing.Color.CadetBlue;
            this.backtologinbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backtologinbutton.Location = new System.Drawing.Point(238, 487);
            this.backtologinbutton.Name = "backtologinbutton";
            this.backtologinbutton.Size = new System.Drawing.Size(194, 48);
            this.backtologinbutton.TabIndex = 10;
            this.backtologinbutton.Text = "GİRİŞ EKRANINA DÖN";
            this.backtologinbutton.UseVisualStyleBackColor = false;
            this.backtologinbutton.Click += new System.EventHandler(this.backtologinbutton_Click);
            // 
            // Registerbutton
            // 
            this.Registerbutton.BackColor = System.Drawing.Color.CadetBlue;
            this.Registerbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Registerbutton.Location = new System.Drawing.Point(499, 487);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(194, 48);
            this.Registerbutton.TabIndex = 11;
            this.Registerbutton.Text = "KAYIT OL";
            this.Registerbutton.UseVisualStyleBackColor = false;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Patient_Tracking.Properties.Resources.Adsız;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 109);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(437, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "KAYIT EKRANI";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 617);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.backtologinbutton);
            this.Controls.Add(this.Kayıtsifretext);
            this.Controls.Add(this.DoktorSoyadi);
            this.Controls.Add(this.DoktorAdi);
            this.Controls.Add(this.Kayıttckimliktext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Kayıttckimliktext;
        private System.Windows.Forms.TextBox DoktorAdi;
        private System.Windows.Forms.TextBox DoktorSoyadi;
        private System.Windows.Forms.TextBox Kayıtsifretext;
        private System.Windows.Forms.Button backtologinbutton;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Label label6;
    }
}