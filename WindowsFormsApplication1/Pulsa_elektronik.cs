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
    public partial class Pulsa_elektronik : Form
    {
        public Pulsa_elektronik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
            cmd.CommandText = "SELECT * FROM pulsa";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksidb.Open();
            MySqlCommand cmd;
            cmd = koneksidb.CreateCommand();
            cmd.CommandText = "INSERT INTO pulsa (no, nama_pembeli, no_hp, operator, tanggal,jumlah_nominal,jumlah_bayar) VALUES(@no, @nama, @nomor, @operator, @tanggal, @nominal, @bayar)";
            cmd.Parameters.AddWithValue("@no", textBox1.Text);
            cmd.Parameters.AddWithValue("@nama", textNama.Text);
            cmd.Parameters.AddWithValue("@nomor", textNope.Text);
            cmd.Parameters.AddWithValue("@operator", textOpe.Text);
            cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
            cmd.Parameters.AddWithValue("@nominal", comboBox1.Text);
            cmd.Parameters.AddWithValue("@bayar", textBay.Text);
            MessageBox.Show("Saved Successfully");
            cmd.ExecuteNonQuery();
            textNama.Text = "";
            textNope.Text = "";
            textOpe.Text = "";
            comboBox1.Text = "";
            textBay.Text = "";
            LoadData();
            koneksidb.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBay.Text = "7000";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBay.Text = "12000";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBay.Text = "22000";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBay.Text = "27000";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                textBay.Text = "51000";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                textBay.Text = "100000";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            koneksidb.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM pulsa WHERE no ='" + textBox1.Text + "'", koneksidb);
            cmd.ExecuteNonQuery();
            LoadData();
            koneksidb.Close();
            MessageBox.Show("Successfull!!", "Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            textNama.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textNope.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textOpe.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            koneksidb.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE pulsa SET `nama_pembeli`='" +textNama.Text + "',`no_hp`='" + textNope.Text + "',`operator`='" + textOpe.Text + "',`jumlah_nominal`='" + comboBox1.Text + "',`jumlah_bayar`='" + textBay.Text + "'WHERE no = '" + textBox1.Text + "'", koneksidb);
            cmd.ExecuteNonQuery();
            LoadData();
            koneksidb.Close();
            MessageBox.Show("Successfull!!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
