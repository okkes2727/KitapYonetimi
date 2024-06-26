namespace KutuphaneYonetim
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
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.listBoxKitaplar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.Btnfiltrele = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblKitapAdi.Location = new System.Drawing.Point(15, 337);
            this.lblKitapAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(154, 32);
            this.lblKitapAdi.TabIndex = 0;
            this.lblKitapAdi.Text = "Kitap Adı:";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblYazar.Location = new System.Drawing.Point(15, 416);
            this.lblYazar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(98, 32);
            this.lblYazar.TabIndex = 1;
            this.lblYazar.Text = "Yazar:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblISBN.Location = new System.Drawing.Point(15, 506);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(84, 32);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Tag = "";
            this.lblISBN.Text = "ISBN:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKitapAdi.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtKitapAdi.Location = new System.Drawing.Point(178, 334);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(553, 35);
            this.txtKitapAdi.TabIndex = 3;
            // 
            // txtISBN
            // 
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtISBN.Location = new System.Drawing.Point(177, 503);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(553, 35);
            this.txtISBN.TabIndex = 4;
            // 
            // txtYazar
            // 
            this.txtYazar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazar.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtYazar.Location = new System.Drawing.Point(177, 413);
            this.txtYazar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(553, 35);
            this.txtYazar.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnEkle.Location = new System.Drawing.Point(177, 548);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(179, 67);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnSil.Location = new System.Drawing.Point(551, 548);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(179, 67);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // listBoxKitaplar
            // 
            this.listBoxKitaplar.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.listBoxKitaplar.FormattingEnabled = true;
            this.listBoxKitaplar.ItemHeight = 32;
            this.listBoxKitaplar.Location = new System.Drawing.Point(753, 317);
            this.listBoxKitaplar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxKitaplar.Name = "listBoxKitaplar";
            this.listBoxKitaplar.Size = new System.Drawing.Size(666, 452);
            this.listBoxKitaplar.TabIndex = 9;
            this.listBoxKitaplar.SelectedIndexChanged += new System.EventHandler(this.listBoxKitaplar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 63);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kütüphane Yönetim Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(745, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kayıtlı Kitaplar";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.btnDuzenle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnDuzenle.Location = new System.Drawing.Point(364, 548);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(179, 67);
            this.btnDuzenle.TabIndex = 7;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // Btnfiltrele
            // 
            this.Btnfiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnfiltrele.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.Btnfiltrele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.Btnfiltrele.Location = new System.Drawing.Point(551, 702);
            this.Btnfiltrele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btnfiltrele.Name = "Btnfiltrele";
            this.Btnfiltrele.Size = new System.Drawing.Size(179, 67);
            this.Btnfiltrele.TabIndex = 12;
            this.Btnfiltrele.Text = "Filtrele";
            this.Btnfiltrele.UseVisualStyleBackColor = true;
            this.Btnfiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListele.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.BtnListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.BtnListele.Location = new System.Drawing.Point(552, 625);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(179, 67);
            this.BtnListele.TabIndex = 13;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 100);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(570, 43);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kitap Ekle, Düzenle ya da Sil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1426, 777);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.Btnfiltrele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxKitaplar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Kütüphane Yönetim Sistemi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox listBoxKitaplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button Btnfiltrele;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

