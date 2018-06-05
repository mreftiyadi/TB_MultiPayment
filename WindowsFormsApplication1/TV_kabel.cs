using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class TV_kabel : Form
    {
        public TV_kabel()
        {
            InitializeComponent();
        }

        MySqlConnection koneksidb = new MySqlConnection("SERVER=localhost;DATABASE=multipayment;UID=root;PASSWORD=;");
        private void Home_Load(object sender, EventArgs e)
        {
            koneksidb.Open();
            LoadData();
            koneksidb.Close();
        }

        public void LoadData()
        {
            MySqlCommand cmd;
            cmd = koneksidb.CreateCommand();
            cmd.CommandText = "SELECT * FROM tv_kabel";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBay_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                textBay.Text = "280000";
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                textBay.Text = "0";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBay.Text = "380000";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBay.Text = "480000";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                textBay.Text = "550000";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                textBay.Text = "0";
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                textBay.Text = "284000";
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                textBay.Text = "350000";
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                textBay.Text = "0";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                textBay.Text = "212000";
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                textBay.Text = "0";
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                textBay.Text = "150000";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksidb.Open();
            MySqlCommand cmd;
            cmd = koneksidb.CreateCommand();
            cmd.CommandText = "INSERT INTO tv_kabel (no, nama, no_layanan, tanggal, tv, paket, jml_bayar) VALUES(@no, @nama, @layanan, @tanggal, @tv, @paket, @bayar)";
            cmd.Parameters.AddWithValue("@no", textBox1.Text);
            cmd.Parameters.AddWithValue("@nama", textNama.Text);
            cmd.Parameters.AddWithValue("@layanan", textNope.Text);
            cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
            cmd.Parameters.AddWithValue("@tv", comboBox2.Text);
            cmd.Parameters.AddWithValue("@paket", comboBox1.Text);
            cmd.Parameters.AddWithValue("@bayar", textBay.Text);
            MessageBox.Show("Saved Successfully");
            cmd.ExecuteNonQuery();
            textNama.Text = "";
            textNope.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            textBay.Text = "";
            LoadData();
            koneksidb.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            koneksidb.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM tv_kabel WHERE no ='" + textBox1.Text + "'", koneksidb);
            cmd.ExecuteNonQuery();
            LoadData();
            koneksidb.Close();
            MessageBox.Show("Successfull!!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            koneksidb.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE tv_kabel SET `nama`='" + textNama.Text + "',`no_layanan`='" + textNope.Text + "',`tv`='" + comboBox2.Text + "',`paket`='" + comboBox1.Text + "',`jml_bayar`='" + textBay.Text + "'WHERE no = '" + textBox1.Text + "'", koneksidb);
            cmd.ExecuteNonQuery();
            LoadData();
            koneksidb.Close();
            MessageBox.Show("Successfull!!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void TV_kabel_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            textNama.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textNope.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            textBay.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
        }
    }
    }
