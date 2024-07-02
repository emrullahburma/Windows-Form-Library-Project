using KutuphaneBLL.interfaces;
using KutuphaneBLL.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace kütüphaneDeneme
{
    public partial class kitapTanimlama : Form
    {
        private IBookIdendification _bookIdendification;
        private IUser _userInterface;

        public kitapTanimlama()
        {
            _userInterface = new UserService();
            _bookIdendification = new BookService();
            InitializeComponent();
        }

        public void GetPastdendification()
        {
            try
            {
                var result = _bookIdendification.GetPastIdendification(new Dictionary<string, object>());
                dataGridView2.DataSource = result;

                if (result.Count() > 0)
                {
                    dataGridView2.Columns[5].Visible = false;
                    dataGridView2.Columns[6].Visible = false;
                    dataGridView2.Columns[7].Visible = false;
                    dataGridView2.Columns[8].Visible = false;
                    dataGridView2.Columns[9].Visible = false;
                }
            }
            catch (Exception hata)
            {

                throw;
            }
        }

        public void IdendificationList()
        {
            try
            {
                var result = _bookIdendification.GetBookIdendification(new Dictionary<string, object>());
                dataGridView1.DataSource = result;

                if (result.Count > 0)
                {
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : " + hata);
            }

        }

        private void kitapAlma_Load(object sender, EventArgs e)
        {
            IdendificationList();
            GetPastdendification();
            try
            {
                var userList = _userInterface.GetUsers(new Dictionary<string, object>());
                var bookList = _bookIdendification.GetBook(new Dictionary<string, object>());

                foreach (var item in userList)
                {
                    var dynamicUser = (IDictionary<string, object>)item;
                    comboBox1.Items.Add(dynamicUser["Kullanıcı Ad"]);
                }

                foreach (var item in bookList)
                {
                    var dynamicBook = (IDictionary<string, object>)item;
                    comboBox2.Items.Add(dynamicBook["Kitap İsmi"]);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Hata Sistem Mesajı : " + error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new Dictionary<string, object>()
                {
                    {"@KitapAlanKullanici",comboBox1.Text },
                    {"@KitapAlmaBaslangic",dateTimePicker1.Value },
                    {"@KitapAlmaBitis", dateTimePicker2.Value},
                    {"@AldigiKitap",comboBox2.Text }
                };

                var result = _bookIdendification.AddBookIdendification(model);

                if (Convert.ToBoolean(result["Status"]) == true)
                    MessageBox.Show("Kayıt işlemi başarılı");
                else
                    MessageBox.Show("Kayıt işlemi başarısız");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt işlemi başarısız");
            }

            IdendificationList();
            GetPastdendification();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kitapEkleme home = new kitapEkleme();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectedId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (checkBox1.Checked == true)
                {
                    var model = new Dictionary<string, object>()
                    {
                        {"@Id",selectedId }
                    };

                    var result = _bookIdendification.DeleteBookIdendification(model);

                    if (Convert.ToBoolean(result["Status"]) == true)
                    {
                        MessageBox.Show("Teslim alma başarılı");
                        IdendificationList();
                    }

                    else
                    {
                        MessageBox.Show("Teslim alma başarısız");
                    }
                }
                else
                {
                    MessageBox.Show("Onay veriniz");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Teslim alma başarısız");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new Dictionary<string, object>
                {
                    {"@SearchKey",textBox1.Text }
                };

                var result = _bookIdendification.SerachBookIdendification(model);
                dataGridView1.DataSource = result;

                if (result.Count > 0)
                {
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                }

            }
            catch (Exception hata)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            IdendificationList();
        }
    }
}