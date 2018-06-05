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
    public partial class Voucher_Game : Form
    {
        public Voucher_Game()
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
            cmd.CommandText = "SELECT * FROM voucher";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bayar = int.Parse(textNama.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                textBay.Text = (bayar * 55500).ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBay.Text = (bayar*105000).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksidb.Open();
            MySqlCommand cmd;
            cmd = koneksidb.CreateCommand();
            cmd.CommandText = "INSERT INTO voucher (no, jenis_voucher, no_hp, tanggal, jml_beli, jml_nominal, jml_bayar) VALUES(@no, @jenis, @hp, @tanggal, @beli, @nominal, @bayar)";
            cmd.Parameters.AddWithValue("@no", textBox1.Text);
            cmd.Parameters.AddWithValue("@jenis", comboBox2.Text);
            cmd.Parameters.AddWithValue("@hp", textNope.Text);
            cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
            cmd.Parameters.AddWithValue("@beli", textNama.Text);
            cmd.Parameters.AddWithValue("@nominal", comboBox1.Text);
            cmd.Parameters.AddWithValue("@bayar", textBay.Text);
            MessageBox.Show("Saved Successfully");
            cmd.ExecuteNonQuery();
            comboBox2.Text = "";
            textNope.Text = "";
            textNama.Text = "";
            comboBox1.Text = "";
            textBay.Text = "";
            LoadData();
            koneksidb.Close();

        }

        private void Voucher_Game_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            koneksidb.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM voucher WHERE no ='" + textBox1.Text + "'", koneksidb);
            cmd.ExecuteNonQuery();
            LoadData();
            koneksidb.Close();
            MessageBox.Show("Successfull!!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            koneksidb.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE voucher SET `jenis_voucher`='" + comboBox2.Text + "',`no_hp`='" + textNope.Text + "',`jml_beli`='" + textNama.Text + "',`jml_nominal`='" + comboBox1.Text + "',`jml_bayar`='" + textBay.Text + "'WHERE no = '" + textBox1.Text + "'", koneksidb);
            cmd.ExecuteNonQuery();
            LoadData();
            koneksidb.Close();
            MessageBox.Show("Successfull!!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textNope.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textNama.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            textBay.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
        }
    }
}
