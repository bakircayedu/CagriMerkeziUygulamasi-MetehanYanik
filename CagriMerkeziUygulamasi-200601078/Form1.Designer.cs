namespace CagriMerkeziUygulamasi_200601078
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.musteriTuru = new System.Windows.Forms.Label();
            this.musteriTuruTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.araBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cagriSonlandirBtn2 = new System.Windows.Forms.Button();
            this.cagriSonlandirBtn = new System.Windows.Forms.Button();
            this.ticariMusteriBilgisi2 = new System.Windows.Forms.Label();
            this.ticariMusteriBilgisi1 = new System.Windows.Forms.Label();
            this.ikinciTicariTemsilci = new System.Windows.Forms.Button();
            this.birinciTicariTemsilci = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ticariMusteriNotu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ticariMusteriLw = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cagriSonlandirBireyselBtn2 = new System.Windows.Forms.Button();
            this.cagliSonlandirBireyselBtn1 = new System.Windows.Forms.Button();
            this.bireyselMusteriBilgisi2 = new System.Windows.Forms.Label();
            this.bireyselMusteriBilgisi1 = new System.Windows.Forms.Label();
            this.ikinciBireyselTemsilci = new System.Windows.Forms.Button();
            this.birinciBireyselTemsilci = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bireyselMusteriNotu = new System.Windows.Forms.TextBox();
            this.bireyselMusteriLw = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sonlananCagrilarLw = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriTuru
            // 
            this.musteriTuru.AutoSize = true;
            this.musteriTuru.Location = new System.Drawing.Point(20, 34);
            this.musteriTuru.Name = "musteriTuru";
            this.musteriTuru.Size = new System.Drawing.Size(142, 30);
            this.musteriTuru.TabIndex = 0;
            this.musteriTuru.Text = "Müşteri Türünüzü Giriniz :\r\n(1- Ticari / 2-Bireysel)";
            // 
            // musteriTuruTxt
            // 
            this.musteriTuruTxt.Location = new System.Drawing.Point(189, 41);
            this.musteriTuruTxt.Name = "musteriTuruTxt";
            this.musteriTuruTxt.Size = new System.Drawing.Size(56, 23);
            this.musteriTuruTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.araBtn);
            this.groupBox1.Controls.Add(this.musteriTuru);
            this.groupBox1.Controls.Add(this.musteriTuruTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Paneli";
            // 
            // araBtn
            // 
            this.araBtn.Location = new System.Drawing.Point(78, 93);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(143, 23);
            this.araBtn.TabIndex = 5;
            this.araBtn.Text = "Arama Yap";
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cagriSonlandirBtn2);
            this.groupBox2.Controls.Add(this.cagriSonlandirBtn);
            this.groupBox2.Controls.Add(this.ticariMusteriBilgisi2);
            this.groupBox2.Controls.Add(this.ticariMusteriBilgisi1);
            this.groupBox2.Controls.Add(this.ikinciTicariTemsilci);
            this.groupBox2.Controls.Add(this.birinciTicariTemsilci);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ticariMusteriNotu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ticariMusteriLw);
            this.groupBox2.Location = new System.Drawing.Point(541, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 287);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticari Müşteri Paneli";
            // 
            // cagriSonlandirBtn2
            // 
            this.cagriSonlandirBtn2.Location = new System.Drawing.Point(579, 83);
            this.cagriSonlandirBtn2.Name = "cagriSonlandirBtn2";
            this.cagriSonlandirBtn2.Size = new System.Drawing.Size(147, 23);
            this.cagriSonlandirBtn2.TabIndex = 9;
            this.cagriSonlandirBtn2.Text = "Çağrıyı Sonlandır";
            this.cagriSonlandirBtn2.UseVisualStyleBackColor = true;
            this.cagriSonlandirBtn2.Click += new System.EventHandler(this.cagriSonlandirBtn2_Click);
            // 
            // cagriSonlandirBtn
            // 
            this.cagriSonlandirBtn.Location = new System.Drawing.Point(579, 41);
            this.cagriSonlandirBtn.Name = "cagriSonlandirBtn";
            this.cagriSonlandirBtn.Size = new System.Drawing.Size(147, 23);
            this.cagriSonlandirBtn.TabIndex = 8;
            this.cagriSonlandirBtn.Text = "Çağrıyı Sonlandır";
            this.cagriSonlandirBtn.UseVisualStyleBackColor = true;
            this.cagriSonlandirBtn.Click += new System.EventHandler(this.cagriSonlandirBtn_Click);
            // 
            // ticariMusteriBilgisi2
            // 
            this.ticariMusteriBilgisi2.AutoSize = true;
            this.ticariMusteriBilgisi2.Location = new System.Drawing.Point(234, 83);
            this.ticariMusteriBilgisi2.Name = "ticariMusteriBilgisi2";
            this.ticariMusteriBilgisi2.Size = new System.Drawing.Size(12, 15);
            this.ticariMusteriBilgisi2.TabIndex = 7;
            this.ticariMusteriBilgisi2.Text = "-";
            // 
            // ticariMusteriBilgisi1
            // 
            this.ticariMusteriBilgisi1.AutoSize = true;
            this.ticariMusteriBilgisi1.Location = new System.Drawing.Point(234, 34);
            this.ticariMusteriBilgisi1.Name = "ticariMusteriBilgisi1";
            this.ticariMusteriBilgisi1.Size = new System.Drawing.Size(12, 15);
            this.ticariMusteriBilgisi1.TabIndex = 6;
            this.ticariMusteriBilgisi1.Text = "-";
            // 
            // ikinciTicariTemsilci
            // 
            this.ikinciTicariTemsilci.Location = new System.Drawing.Point(22, 70);
            this.ikinciTicariTemsilci.Name = "ikinciTicariTemsilci";
            this.ikinciTicariTemsilci.Size = new System.Drawing.Size(206, 40);
            this.ikinciTicariTemsilci.TabIndex = 5;
            this.ikinciTicariTemsilci.Text = "Çağrıyı 2. Ticari Müşteri Temsilcisine Ata (Mevcut Çağrıyı Sonlandırır)";
            this.ikinciTicariTemsilci.UseVisualStyleBackColor = true;
            this.ikinciTicariTemsilci.Click += new System.EventHandler(this.ikinciTicariTemsilci_Click);
            // 
            // birinciTicariTemsilci
            // 
            this.birinciTicariTemsilci.Location = new System.Drawing.Point(22, 20);
            this.birinciTicariTemsilci.Name = "birinciTicariTemsilci";
            this.birinciTicariTemsilci.Size = new System.Drawing.Size(206, 42);
            this.birinciTicariTemsilci.TabIndex = 4;
            this.birinciTicariTemsilci.Text = "Çağrıyı 1. Ticari Müşteri Temsilcisine Ata (Mevcut Çağrıyı Sonlandırır)";
            this.birinciTicariTemsilci.UseVisualStyleBackColor = true;
            this.birinciTicariTemsilci.Click += new System.EventHandler(this.birinciTicariTemsilci_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri Notu";
            // 
            // ticariMusteriNotu
            // 
            this.ticariMusteriNotu.Location = new System.Drawing.Point(568, 158);
            this.ticariMusteriNotu.Multiline = true;
            this.ticariMusteriNotu.Name = "ticariMusteriNotu";
            this.ticariMusteriNotu.Size = new System.Drawing.Size(242, 123);
            this.ticariMusteriNotu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Güncel Çağrı Sırası";
            // 
            // ticariMusteriLw
            // 
            this.ticariMusteriLw.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ticariMusteriLw.BackColor = System.Drawing.SystemColors.Window;
            this.ticariMusteriLw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ticariMusteriLw.Location = new System.Drawing.Point(6, 158);
            this.ticariMusteriLw.Name = "ticariMusteriLw";
            this.ticariMusteriLw.RightToLeftLayout = true;
            this.ticariMusteriLw.Size = new System.Drawing.Size(546, 123);
            this.ticariMusteriLw.TabIndex = 0;
            this.ticariMusteriLw.UseCompatibleStateImageBehavior = false;
            this.ticariMusteriLw.View = System.Windows.Forms.View.List;
            this.ticariMusteriLw.SelectedIndexChanged += new System.EventHandler(this.ticariMusteriLw_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cagriSonlandirBireyselBtn2);
            this.groupBox3.Controls.Add(this.cagliSonlandirBireyselBtn1);
            this.groupBox3.Controls.Add(this.bireyselMusteriBilgisi2);
            this.groupBox3.Controls.Add(this.bireyselMusteriBilgisi1);
            this.groupBox3.Controls.Add(this.ikinciBireyselTemsilci);
            this.groupBox3.Controls.Add(this.birinciBireyselTemsilci);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.bireyselMusteriNotu);
            this.groupBox3.Controls.Add(this.bireyselMusteriLw);
            this.groupBox3.Location = new System.Drawing.Point(541, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(832, 285);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bireysel Müşteri Paneli";
            // 
            // cagriSonlandirBireyselBtn2
            // 
            this.cagriSonlandirBireyselBtn2.Location = new System.Drawing.Point(579, 77);
            this.cagriSonlandirBireyselBtn2.Name = "cagriSonlandirBireyselBtn2";
            this.cagriSonlandirBireyselBtn2.Size = new System.Drawing.Size(147, 23);
            this.cagriSonlandirBireyselBtn2.TabIndex = 11;
            this.cagriSonlandirBireyselBtn2.Text = "Çağrıyı Sonlandır";
            this.cagriSonlandirBireyselBtn2.UseVisualStyleBackColor = true;
            this.cagriSonlandirBireyselBtn2.Click += new System.EventHandler(this.cagriSonlandirBireyselBtn2_Click);
            // 
            // cagliSonlandirBireyselBtn1
            // 
            this.cagliSonlandirBireyselBtn1.Location = new System.Drawing.Point(579, 36);
            this.cagliSonlandirBireyselBtn1.Name = "cagliSonlandirBireyselBtn1";
            this.cagliSonlandirBireyselBtn1.Size = new System.Drawing.Size(147, 23);
            this.cagliSonlandirBireyselBtn1.TabIndex = 10;
            this.cagliSonlandirBireyselBtn1.Text = "Çağrıyı Sonlandır";
            this.cagliSonlandirBireyselBtn1.UseVisualStyleBackColor = true;
            this.cagliSonlandirBireyselBtn1.Click += new System.EventHandler(this.cagliSonlandirBireyselBtn1_Click);
            // 
            // bireyselMusteriBilgisi2
            // 
            this.bireyselMusteriBilgisi2.AutoSize = true;
            this.bireyselMusteriBilgisi2.Location = new System.Drawing.Point(244, 85);
            this.bireyselMusteriBilgisi2.Name = "bireyselMusteriBilgisi2";
            this.bireyselMusteriBilgisi2.Size = new System.Drawing.Size(12, 15);
            this.bireyselMusteriBilgisi2.TabIndex = 9;
            this.bireyselMusteriBilgisi2.Text = "-";
            // 
            // bireyselMusteriBilgisi1
            // 
            this.bireyselMusteriBilgisi1.AutoSize = true;
            this.bireyselMusteriBilgisi1.Location = new System.Drawing.Point(244, 36);
            this.bireyselMusteriBilgisi1.Name = "bireyselMusteriBilgisi1";
            this.bireyselMusteriBilgisi1.Size = new System.Drawing.Size(12, 15);
            this.bireyselMusteriBilgisi1.TabIndex = 8;
            this.bireyselMusteriBilgisi1.Text = "-";
            // 
            // ikinciBireyselTemsilci
            // 
            this.ikinciBireyselTemsilci.Location = new System.Drawing.Point(22, 72);
            this.ikinciBireyselTemsilci.Name = "ikinciBireyselTemsilci";
            this.ikinciBireyselTemsilci.Size = new System.Drawing.Size(216, 40);
            this.ikinciBireyselTemsilci.TabIndex = 7;
            this.ikinciBireyselTemsilci.Text = "Çağrıyı 2. Bireysel Müşteri Temsilcisine Ata (Mevcut Çağrıyı Sonlandırır)";
            this.ikinciBireyselTemsilci.UseVisualStyleBackColor = true;
            this.ikinciBireyselTemsilci.Click += new System.EventHandler(this.ikinciBireyselTemsilci_Click);
            // 
            // birinciBireyselTemsilci
            // 
            this.birinciBireyselTemsilci.Location = new System.Drawing.Point(22, 22);
            this.birinciBireyselTemsilci.Name = "birinciBireyselTemsilci";
            this.birinciBireyselTemsilci.Size = new System.Drawing.Size(216, 42);
            this.birinciBireyselTemsilci.TabIndex = 6;
            this.birinciBireyselTemsilci.Text = "Çağrıyı 1. Bireysel Müşteri Temsilcisine Ata (Mevcut Çağrıyı Sonlandırır)";
            this.birinciBireyselTemsilci.UseVisualStyleBackColor = true;
            this.birinciBireyselTemsilci.Click += new System.EventHandler(this.birinciBireyselTemsilci_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müşteri Notu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Güncel Çağrı Sırası";
            // 
            // bireyselMusteriNotu
            // 
            this.bireyselMusteriNotu.Location = new System.Drawing.Point(568, 139);
            this.bireyselMusteriNotu.Multiline = true;
            this.bireyselMusteriNotu.Name = "bireyselMusteriNotu";
            this.bireyselMusteriNotu.Size = new System.Drawing.Size(242, 140);
            this.bireyselMusteriNotu.TabIndex = 3;
            // 
            // bireyselMusteriLw
            // 
            this.bireyselMusteriLw.Location = new System.Drawing.Point(6, 139);
            this.bireyselMusteriLw.Name = "bireyselMusteriLw";
            this.bireyselMusteriLw.Size = new System.Drawing.Size(546, 140);
            this.bireyselMusteriLw.TabIndex = 0;
            this.bireyselMusteriLw.UseCompatibleStateImageBehavior = false;
            this.bireyselMusteriLw.View = System.Windows.Forms.View.List;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sonlananCagrilarLw);
            this.groupBox4.Location = new System.Drawing.Point(12, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(500, 394);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sonlanan Çağrılar";
            // 
            // sonlananCagrilarLw
            // 
            this.sonlananCagrilarLw.Location = new System.Drawing.Point(6, 22);
            this.sonlananCagrilarLw.Name = "sonlananCagrilarLw";
            this.sonlananCagrilarLw.Size = new System.Drawing.Size(488, 366);
            this.sonlananCagrilarLw.TabIndex = 0;
            this.sonlananCagrilarLw.UseCompatibleStateImageBehavior = false;
            this.sonlananCagrilarLw.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 608);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Çağrı Merkezi Uygulaması";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label musteriTuru;
        private TextBox musteriTuruTxt;
        private GroupBox groupBox1;
        private Button araBtn;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListView ticariMusteriLw;
        private ListView bireyselMusteriLw;
        private GroupBox groupBox4;
        private ListView sonlananCagrilarLw;
        private Label label3;
        private TextBox ticariMusteriNotu;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox bireyselMusteriNotu;
        private Button ikinciTicariTemsilci;
        private Button birinciTicariTemsilci;
        private Button ikinciBireyselTemsilci;
        private Button birinciBireyselTemsilci;
        private Label ticariMusteriBilgisi1;
        private Label ticariMusteriBilgisi2;
        private Label bireyselMusteriBilgisi2;
        private Label bireyselMusteriBilgisi1;
        private Button cagriSonlandirBtn;
        private Button cagriSonlandirBtn2;
        private Button cagriSonlandirBireyselBtn2;
        private Button cagliSonlandirBireyselBtn1;
    }
}