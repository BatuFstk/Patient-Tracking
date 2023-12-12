namespace Patient_Tracking
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tckimliktextbox = new System.Windows.Forms.TextBox();
            this.Sifretextbox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.BacktoregisterButton = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(993, 109);
            this.panel1.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(241, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC KİMLİK NO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(301, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŞİFRE : ";
            // 
            // Tckimliktextbox
            // 
            this.Tckimliktextbox.BackColor = System.Drawing.Color.White;
            this.Tckimliktextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tckimliktextbox.Location = new System.Drawing.Point(365, 283);
            this.Tckimliktextbox.Multiline = true;
            this.Tckimliktextbox.Name = "Tckimliktextbox";
            this.Tckimliktextbox.Size = new System.Drawing.Size(288, 33);
            this.Tckimliktextbox.TabIndex = 3;
            this.Tckimliktextbox.TextChanged += new System.EventHandler(this.Tckimliktextbox_TextChanged);
            // 
            // Sifretextbox
            // 
            this.Sifretextbox.BackColor = System.Drawing.Color.White;
            this.Sifretextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifretextbox.Location = new System.Drawing.Point(365, 360);
            this.Sifretextbox.Multiline = true;
            this.Sifretextbox.Name = "Sifretextbox";
            this.Sifretextbox.PasswordChar = '*';
            this.Sifretextbox.Size = new System.Drawing.Size(288, 33);
            this.Sifretextbox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.CadetBlue;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginButton.Location = new System.Drawing.Point(519, 432);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(134, 48);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "GİRİŞ";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // BacktoregisterButton
            // 
            this.BacktoregisterButton.BackColor = System.Drawing.Color.CadetBlue;
            this.BacktoregisterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BacktoregisterButton.Location = new System.Drawing.Point(256, 432);
            this.BacktoregisterButton.Name = "BacktoregisterButton";
            this.BacktoregisterButton.Size = new System.Drawing.Size(194, 48);
            this.BacktoregisterButton.TabIndex = 6;
            this.BacktoregisterButton.Text = "KAYIT EKRANINA DÖN";
            this.BacktoregisterButton.UseVisualStyleBackColor = false;
            this.BacktoregisterButton.Click += new System.EventHandler(this.BacktoregisterButton_Click);
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
            this.label6.Location = new System.Drawing.Point(445, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "GİRİŞ EKRANI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 638);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BacktoregisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Sifretextbox);
            this.Controls.Add(this.Tckimliktextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox Tckimliktextbox;
        private System.Windows.Forms.TextBox Sifretextbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button BacktoregisterButton;
        private System.Windows.Forms.Label label6;
    }
}

