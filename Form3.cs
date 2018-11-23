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
using System.Data;

namespace PE_1._0
{
    public partial class login_frm : Form
    {
        MySqlConnection conexion = new MySqlConnection("SERVER=localhost; DATABASE=prestamos; UID=root; PASSWORD=chuyon12;");
        private MySqlCommand cmd;
        private MySqlCommandBuilder cmBuilder;
        private MySqlDataAdapter da;
        private DataSet ds;
        private DataTable dt;
        private DataRow dr;
        public login_frm()
        {
            InitializeComponent();
        }
        public string Buscar(string consulta)
        {
            string password;

            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dr = dt.Rows[0];
            password = Convert.ToString(dr[0]);
            conexion.Close();

            return password;
        }
        private void check_password_ckbx_CheckedChanged(object sender, EventArgs e)
        {

            if (show_password_cbx.Checked)
            {
                pswrd_txtbx.UseSystemPasswordChar = false;
            }
            else
            {
                pswrd_txtbx.UseSystemPasswordChar = true;
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            String buscar = "select password from usuarios where codigo=" + user_txtbx.Text;
            if (Buscar(buscar) == pswrd_txtbx.Text)
            {
                catalog_frm catalogo = new catalog_frm();
                this.Close();
                catalogo.Show();
            }
            else
            {
                MessageBox.Show("Contraseña Icorrecta");

            }
        }

        private void user_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarNumeros(e);
        }
    }
}
