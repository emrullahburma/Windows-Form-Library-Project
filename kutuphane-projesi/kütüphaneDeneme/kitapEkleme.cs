using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KutuphaneBLL.interfaces;
using KutuphaneBLL.services;

namespace kütüphaneDeneme
{
    public partial class kitapEkleme : Form
    {
        private readonly IBook _bookService;

        public kitapEkleme()
        {
            _bookService = new BookService();
            InitializeComponent();
        }

        public void GetBookList()
        {
            try
            {
                var result = _bookService.GetBook(new Dictionary<string, object>());
                dataGridView1.DataSource = result;

                if(result.Count != 0) 
                {
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Hata Sistem Mesajı :" + error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new Dictionary<string, object>();
            model.Add("@SearhKey", textBox1.Text);

            try
            {
                var result = _bookService.SearchBook(model);
                dataGridView1.DataSource = result;

                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
            }

            catch (Exception error)
            {
                MessageBox.Show("Sistem Mesajı: " + error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var model = new Dictionary<string, object>();
            model.Add("@KitapIsim", textBox2.Text);
            model.Add("@KitapYazar", textBox3.Text);
            model.Add("@KitapSayfaSayisi", textBox4.Text);
            model.Add("@KitapYayinEvi", textBox5.Text);

            var result = _bookService.AddBook(model);

            if (Convert.ToBoolean(result["Status"]) == true)
            {
                MessageBox.Show("Kayıt Başarılı");
                GetBookList();
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetBookList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult verify;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var model = new Dictionary<string, object>();
            model.Add("@KitapId", id);


            verify = MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Silme İşlemi", MessageBoxButtons.YesNo);

            try
            {
                if (DialogResult.Yes == verify)
                {
                    var result = _bookService.DeleteBook(model);
                    if (Convert.ToBoolean(result["Status"]) == true)
                    {
                        MessageBox.Show("Silme İşlemi Başarılı");
                        GetBookList();
                    }
                    else
                    {
                        MessageBox.Show("Silme İşlemi Başarısız");
                    }
                }
                else
                {
                    MessageBox.Show("Silme işlemi için ");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Silme İşlemi Başarısız");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var model = new Dictionary<string, object>();
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            try
            {
                model.Add("@KitapId", id);
                model.Add("@KitapIsim", textBox12.Text);
                model.Add("@KitapYazar", textBox15.Text);
                model.Add("@KitapSayfaSayisi", textBox14.Text);
                model.Add("@KitapYayinEvi", textBox13.Text);

                var result = _bookService.UpdateBook(model);
                if (Convert.ToBoolean(result["Status"]) == true)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı");
                    GetBookList();
                }
                else
                {
                    MessageBox.Show("Güncelleme İşlemi Başarısız");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox12.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox14.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox15.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullaniciEkleme kullaniciEkleme = new kullaniciEkleme();
            kullaniciEkleme.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kitapTanimlama kitapAlma = new kitapTanimlama();
            kitapAlma.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GetBookList();
        }
    }
}
