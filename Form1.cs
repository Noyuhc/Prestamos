using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_1._0
{
    public partial class home_frm : Form
    {
        public home_frm()
        {
            InitializeComponent();
        }

        private void home_image_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sign_in_frm sign_in = new sign_in_frm();
            sign_in.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login_frm login = new login_frm();
            login.Show();
        }
    }
}
