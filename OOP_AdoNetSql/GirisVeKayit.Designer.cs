namespace OOP_ADO.NET_SQL
{
    partial class GirisVeKayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnSifre = new System.Windows.Forms.Button();
            this.txtKGsifre = new System.Windows.Forms.TextBox();
            this.txtKGkadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPKkayitOl = new System.Windows.Forms.Button();
            this.txtPKadSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPKkadi = new System.Windows.Forms.TextBox();
            this.txtPKsifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPKsifreRPT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKYkadi = new System.Windows.Forms.TextBox();
            this.txtKYsifre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.btnSifre);
            this.groupBox1.Controls.Add(this.txtKGsifre);
            this.groupBox1.Controls.Add(this.txtKGkadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 361);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Girişi";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(22, 189);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(232, 50);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnSifre
            // 
            this.btnSifre.Location = new System.Drawing.Point(218, 121);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(35, 30);
            this.btnSifre.TabIndex = 2;
            this.btnSifre.Text = "👁️";
            this.btnSifre.UseVisualStyleBackColor = true;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // txtKGsifre
            // 
            this.txtKGsifre.Location = new System.Drawing.Point(85, 121);
            this.txtKGsifre.Multiline = true;
            this.txtKGsifre.Name = "txtKGsifre";
            this.txtKGsifre.PasswordChar = '*';
            this.txtKGsifre.Size = new System.Drawing.Size(127, 30);
            this.txtKGsifre.TabIndex = 1;
            // 
            // txtKGkadi
            // 
            this.txtKGkadi.Location = new System.Drawing.Point(85, 77);
            this.txtKGkadi.Multiline = true;
            this.txtKGkadi.Name = "txtKGkadi";
            this.txtKGkadi.Size = new System.Drawing.Size(169, 30);
            this.txtKGkadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtKYsifre);
            this.groupBox2.Controls.Add(this.btnPKkayitOl);
            this.groupBox2.Controls.Add(this.txtKYkadi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPKsifreRPT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPKsifre);
            this.groupBox2.Controls.Add(this.txtPKkadi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPKadSoyad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(344, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Kayıt";
            // 
            // btnPKkayitOl
            // 
            this.btnPKkayitOl.Location = new System.Drawing.Point(20, 293);
            this.btnPKkayitOl.Name = "btnPKkayitOl";
            this.btnPKkayitOl.Size = new System.Drawing.Size(232, 50);
            this.btnPKkayitOl.TabIndex = 3;
            this.btnPKkayitOl.Text = "Kayıt Ol";
            this.btnPKkayitOl.UseVisualStyleBackColor = true;
            this.btnPKkayitOl.Click += new System.EventHandler(this.btnPKkayitOl_Click);
            // 
            // txtPKadSoyad
            // 
            this.txtPKadSoyad.Location = new System.Drawing.Point(85, 33);
            this.txtPKadSoyad.Multiline = true;
            this.txtPKadSoyad.Name = "txtPKadSoyad";
            this.txtPKadSoyad.Size = new System.Drawing.Size(127, 22);
            this.txtPKadSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad Soyad : ";
            // 
            // txtPKkadi
            // 
            this.txtPKkadi.Location = new System.Drawing.Point(85, 66);
            this.txtPKkadi.Multiline = true;
            this.txtPKkadi.Name = "txtPKkadi";
            this.txtPKkadi.Size = new System.Drawing.Size(127, 22);
            this.txtPKkadi.TabIndex = 1;
            // 
            // txtPKsifre
            // 
            this.txtPKsifre.Location = new System.Drawing.Point(85, 99);
            this.txtPKsifre.Multiline = true;
            this.txtPKsifre.Name = "txtPKsifre";
            this.txtPKsifre.PasswordChar = '*';
            this.txtPKsifre.Size = new System.Drawing.Size(127, 22);
            this.txtPKsifre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre Tekrar : ";
            // 
            // txtPKsifreRPT
            // 
            this.txtPKsifreRPT.Location = new System.Drawing.Point(85, 132);
            this.txtPKsifreRPT.Multiline = true;
            this.txtPKsifreRPT.Name = "txtPKsifreRPT";
            this.txtPKsifreRPT.PasswordChar = '*';
            this.txtPKsifreRPT.Size = new System.Drawing.Size(127, 22);
            this.txtPKsifreRPT.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Şifre : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "-------------------------------------------------------------------------------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kayıt Yapan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Şifre : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kullanıcı Adı : ";
            // 
            // txtKYkadi
            // 
            this.txtKYkadi.Location = new System.Drawing.Point(83, 204);
            this.txtKYkadi.Multiline = true;
            this.txtKYkadi.Name = "txtKYkadi";
            this.txtKYkadi.Size = new System.Drawing.Size(129, 22);
            this.txtKYkadi.TabIndex = 1;
            // 
            // txtKYsifre
            // 
            this.txtKYsifre.Location = new System.Drawing.Point(83, 239);
            this.txtKYsifre.Multiline = true;
            this.txtKYsifre.Name = "txtKYsifre";
            this.txtKYsifre.PasswordChar = '*';
            this.txtKYsifre.Size = new System.Drawing.Size(129, 22);
            this.txtKYsifre.TabIndex = 1;
            // 
            // GirisVeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GirisVeKayit";
            this.Text = "Giriş ve Kayıt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.TextBox txtKGsifre;
        private System.Windows.Forms.TextBox txtKGkadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPKkayitOl;
        private System.Windows.Forms.TextBox txtPKkadi;
        private System.Windows.Forms.TextBox txtPKadSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPKsifreRPT;
        private System.Windows.Forms.TextBox txtPKsifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKYsifre;
        private System.Windows.Forms.TextBox txtKYkadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

