using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda akan Keluar dari Aplikasi ini ?", "Informasi", MessageBoxButtons.YesNo) == DialogResult.No) ;
            else
            {
                Close();
            }
        }

        private void elektronikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pulsa_elektronik pulsa = new Pulsa_elektronik();
            pulsa.ShowDialog();
        }

        private void listrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pulsa_Listrik listrik = new Pulsa_Listrik();
            listrik.ShowDialog();
        }

        private void gameOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voucher_Game game = new Voucher_Game();
            game.ShowDialog();
        }

        private void tVKabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TV_kabel tv = new TV_kabel();
            tv.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timer1.Enabled = true;
        }
    }
}
