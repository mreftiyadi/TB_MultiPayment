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
    public partial class LoginAwal : Form
    {
        public LoginAwal()
        {
            InitializeComponent();
        }

        private void LoginAwal_Load(object sender, EventArgs e)
        {

        }

        private void Login1Btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
