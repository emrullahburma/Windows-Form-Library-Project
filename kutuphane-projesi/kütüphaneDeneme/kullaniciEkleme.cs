using KutuphaneBLL.interfaces;
using KutuphaneBLL.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace kütüphaneDeneme
{
    public partial class kullaniciEkleme : Form
    {
        private IUser _userInterface;

        public kullaniciEkleme()
        {
            _userInterface = new UserService();
            InitializeComponent();
        }

        public void GetUserList()
        {
            var result = _userInterface.GetUsers(new Dictionary<string, object>());
            dataGridView1.DataSource = result;

            if (result.Count > 0)
            {
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
            }
        }

        private void kullaniciEkleme_Load(object sender, EventArgs e)
        {
            GetUserList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var model = new Dictionary<string, object>();
            model.Add("@UserName", textBox2.Text);
            model.Add("@UserSurname", textBox3.Text);
            model.Add("@PhoneNumber", textBox4.Text);
            model.Add("@UserMail", textBox5.Text);
            model.Add("@UserAddress", textBox6.Text);
            try
            {
                var result = _userInterface.SaveUser(model);
                if (Convert.ToBoolean(result["Status"]) == true)
                {
                    MessageBox.Show("Kullanıcı başarı ile kaydedildi");
                    GetUserList();
                }
                else
                {
                    MessageBox.Show("Kullanıcı kaydı başarısız");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kullanıcı kaydı başarısız");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                var model = new Dictionary<string, object>();
                string selectedUser = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                model.Add("@KullaniciId", selectedUser);

                try
                {
                    var result = _userInterface.DeleteUser(model);

                    if (Convert.ToBoolean(result["Status"]) == true)
                        MessageBox.Show($"{selectedUser} id li kullanıcı silindi");
                    else
                        MessageBox.Show("Kullanıcı silinemedi");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Kullanıcı silinemedi");
                }
                GetUserList();
            }
            else
            {
                MessageBox.Show("Onay vermeniz gerekmektedir");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new Dictionary<string, object>();
            model.Add("@SearchKey", textBox1.Text);
            try
            {
                var result = _userInterface.SearchUser(model);
                dataGridView1.DataSource = result;

                if(result.Count != 0)
                {
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    dataGridView1.Columns[11].Visible = false;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GetUserList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectedUser = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var model = new Dictionary<string, object>();
            model.Add("@KullaniciAd", textBox11.Text);
            model.Add("@KullaniciSoyad", textBox10.Text);
            model.Add("@KullaniciTel", textBox9.Text);
            model.Add("@KullaniciEposta", textBox8.Text);
            model.Add("@KullaniciAdres", textBox7.Text);
            model.Add("@KullaniciId", selectedUser);

            try
            {
                var result = _userInterface.UpdateUser(model);

                if (Convert.ToBoolean(result["Status"]) == true)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı");
                    GetUserList();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme işlemi başarısız");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox11.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            kitapEkleme kitapEkle = new kitapEkleme();
            kitapEkle.Show();
            this.Hide();
        }

    }
}
