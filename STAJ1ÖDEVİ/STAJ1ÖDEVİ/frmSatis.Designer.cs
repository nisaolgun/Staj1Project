
namespace STAJ1ÖDEVİ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamFiyatı = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatışİptali = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSatışlarıListeleme = new System.Windows.Forms.Button();
            this.btnÜrünListeleme = new System.Windows.Forms.Button();
            this.btnÜrünEkleme = new System.Windows.Forms.Button();
            this.btnMüşteriListeleme = new System.Windows.Forms.Button();
            this.btnMüşteriEkleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(31, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(119, 117);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(135, 20);
            this.txtTelefon.TabIndex = 11;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(119, 66);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(135, 20);
            this.txtAdSoyad.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad Soyad";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(119, 27);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(135, 20);
            this.txtTc.TabIndex = 8;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtToplamFiyatı);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSatışFiyatı);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMiktari);
            this.groupBox2.Controls.Add(this.txtÜrünAdı);
            this.groupBox2.Location = new System.Drawing.Point(31, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 222);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salon İşlemleri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Toplam Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Satış Fiyatı";
            // 
            // txtToplamFiyatı
            // 
            this.txtToplamFiyatı.Location = new System.Drawing.Point(110, 174);
            this.txtToplamFiyatı.Name = "txtToplamFiyatı";
            this.txtToplamFiyatı.Size = new System.Drawing.Size(135, 20);
            this.txtToplamFiyatı.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Miktarı";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(110, 29);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(135, 20);
            this.txtBarkodNo.TabIndex = 7;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ürün Adı";
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.Location = new System.Drawing.Point(110, 139);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(135, 20);
            this.txtSatışFiyatı.TabIndex = 9;
            this.txtSatışFiyatı.TextChanged += new System.EventHandler(this.txtSatışFiyatı_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Barkod No";
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(110, 104);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(135, 20);
            this.txtMiktari.TabIndex = 12;
            this.txtMiktari.TextChanged += new System.EventHandler(this.txtMiktari_TextChanged);
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(110, 66);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(135, 20);
            this.txtÜrünAdı.TabIndex = 14;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(60, 637);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(225, 66);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.BackColor = System.Drawing.Color.White;
            this.btnSatışYap.Location = new System.Drawing.Point(714, 637);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(91, 55);
            this.btnSatışYap.TabIndex = 4;
            this.btnSatışYap.Text = "SATIŞ YAP";
            this.btnSatışYap.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(711, 232);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 47);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatışİptali
            // 
            this.btnSatışİptali.BackColor = System.Drawing.Color.White;
            this.btnSatışİptali.Location = new System.Drawing.Point(711, 310);
            this.btnSatışİptali.Name = "btnSatışİptali";
            this.btnSatışİptali.Size = new System.Drawing.Size(75, 45);
            this.btnSatışİptali.TabIndex = 6;
            this.btnSatışİptali.Text = "SATIŞ İPTALİ";
            this.btnSatışİptali.UseVisualStyleBackColor = false;
            this.btnSatışİptali.Click += new System.EventHandler(this.btnSatışİptali_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(541, 637);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 55);
            this.label10.TabIndex = 7;
            this.label10.Text = "GENEL TOPLAM";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSatışlarıListeleme);
            this.panel1.Controls.Add(this.btnÜrünListeleme);
            this.panel1.Controls.Add(this.btnÜrünEkleme);
            this.panel1.Controls.Add(this.btnMüşteriListeleme);
            this.panel1.Controls.Add(this.btnMüşteriEkleme);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 116);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(716, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Marka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kategori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSatışlarıListeleme
            // 
            this.btnSatışlarıListeleme.Location = new System.Drawing.Point(488, 51);
            this.btnSatışlarıListeleme.Name = "btnSatışlarıListeleme";
            this.btnSatışlarıListeleme.Size = new System.Drawing.Size(90, 36);
            this.btnSatışlarıListeleme.TabIndex = 4;
            this.btnSatışlarıListeleme.Text = "Satışları Listeleme";
            this.btnSatışlarıListeleme.UseVisualStyleBackColor = true;
            this.btnSatışlarıListeleme.Click += new System.EventHandler(this.btnSatışlarıListeleme_Click);
            // 
            // btnÜrünListeleme
            // 
            this.btnÜrünListeleme.Location = new System.Drawing.Point(394, 51);
            this.btnÜrünListeleme.Name = "btnÜrünListeleme";
            this.btnÜrünListeleme.Size = new System.Drawing.Size(88, 36);
            this.btnÜrünListeleme.TabIndex = 3;
            this.btnÜrünListeleme.Text = "Ürün Listeleme";
            this.btnÜrünListeleme.UseVisualStyleBackColor = true;
            this.btnÜrünListeleme.Click += new System.EventHandler(this.btnÜrünListeleme_Click);
            // 
            // btnÜrünEkleme
            // 
            this.btnÜrünEkleme.Location = new System.Drawing.Point(293, 51);
            this.btnÜrünEkleme.Name = "btnÜrünEkleme";
            this.btnÜrünEkleme.Size = new System.Drawing.Size(95, 37);
            this.btnÜrünEkleme.TabIndex = 2;
            this.btnÜrünEkleme.Text = "Ürün Ekleme";
            this.btnÜrünEkleme.UseVisualStyleBackColor = true;
            this.btnÜrünEkleme.Click += new System.EventHandler(this.btnÜrünEkleme_Click);
            // 
            // btnMüşteriListeleme
            // 
            this.btnMüşteriListeleme.Location = new System.Drawing.Point(160, 53);
            this.btnMüşteriListeleme.Name = "btnMüşteriListeleme";
            this.btnMüşteriListeleme.Size = new System.Drawing.Size(86, 35);
            this.btnMüşteriListeleme.TabIndex = 1;
            this.btnMüşteriListeleme.Text = "Müşteri Listeleme";
            this.btnMüşteriListeleme.UseVisualStyleBackColor = true;
            this.btnMüşteriListeleme.Click += new System.EventHandler(this.btnMüşteriListeleme_Click);
            // 
            // btnMüşteriEkleme
            // 
            this.btnMüşteriEkleme.Location = new System.Drawing.Point(59, 53);
            this.btnMüşteriEkleme.Name = "btnMüşteriEkleme";
            this.btnMüşteriEkleme.Size = new System.Drawing.Size(86, 35);
            this.btnMüşteriEkleme.TabIndex = 0;
            this.btnMüşteriEkleme.Text = "Müşteri Ekleme";
            this.btnMüşteriEkleme.UseVisualStyleBackColor = true;
            this.btnMüşteriEkleme.Click += new System.EventHandler(this.btnMüşteriEkleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(817, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSatışİptali);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSatışYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamFiyatı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSatışFiyatı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSatışYap;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatışİptali;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatışlarıListeleme;
        private System.Windows.Forms.Button btnÜrünListeleme;
        private System.Windows.Forms.Button btnÜrünEkleme;
        private System.Windows.Forms.Button btnMüşteriListeleme;
        private System.Windows.Forms.Button btnMüşteriEkleme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

