namespace kütüphaneDeneme
{
    partial class kitapEkleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(852, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(768, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitap Yazarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sayfa Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yayın Evi";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Yeni Kayıt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 27);
            this.button3.TabIndex = 12;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 289);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 337);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitap Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitap Sil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Kullanıcı Seçere Silme İşlemini Gerçekleştirebilirsiniz";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(112, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Onay";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(81, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 29);
            this.button5.TabIndex = 0;
            this.button5.Text = "Seçili Öğeyi sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.textBox15);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.textBox14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1040, 308);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kitap Bilgilerini Güncelle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Kullanıcı Seçerek Bilgilerini Güncelleyebilirsiniz";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Kitap Adı";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(149, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 27);
            this.button6.TabIndex = 24;
            this.button6.Text = "Temizle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(135, 117);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 20;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(135, 73);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Yayın Evi";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(29, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 27);
            this.button7.TabIndex = 23;
            this.button7.Text = "Güncelle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(135, 163);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Kitap Yazarı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Sayfa Sayısı";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(135, 206);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(784, 641);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(276, 29);
            this.button4.TabIndex = 15;
            this.button4.Text = "Kullanıcı Ekle Sayfası";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(956, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 29);
            this.button8.TabIndex = 16;
            this.button8.Text = "Temizle";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(16, 641);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(276, 29);
            this.button10.TabIndex = 17;
            this.button10.Text = "Kitap Alma Sayfası";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // kitapEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 682);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kitapEkleme";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button10;
    }
}

