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
    public partial class sign_in_frm : Form
    {
        MySqlConnection conexion = new MySqlConnection("SERVER=localhost; DATABASE=prestamos; UID=root; PASSWORD=chuyon12;");
        private MySqlCommand cmd;
        private MySqlCommandBuilder cmBuilder;
        private MySqlDataAdapter da;
        private DataSet ds;

        public sign_in_frm()
        {
            InitializeComponent();
        }
        public bool Insertar(string consulta)
        {
            bool agregado = false;
            int rows = 0;

            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();

            if(rows > 0)
            {
                agregado = true;
            }

            conexion.Close();

            return agregado;
        }
       
        private void show1_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (show1_cbx.Checked)
            {
                password_txtbx.UseSystemPasswordChar = false;
            }
            else
            {
                password_txtbx.UseSystemPasswordChar = true;
            }
        }

        private void show2_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (show2_cbx.Checked)
            {
                confirm_password_txtbx.UseSystemPasswordChar = false;
            }
            else
            {
                confirm_password_txtbx.UseSystemPasswordChar = true;
            }
        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            string agregar = "insert into usuarios values('"+apellidos_txtbx.Text+" "+nombres_txtbx.Text+"','"+codigo_bx.Text+"','"
                +carrera_cmbx.Text+"',"+semestre_cmbx.Text+",'"+password_txtbx.Text+"')";
            if (Insertar(agregar))
            {
                MessageBox.Show("Registrado");
            }
            else
            {
                MessageBox.Show("Error");
            }
            this.Close();
        }

        private void apellidos_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetras(e);
        }

        private void nombres_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetras(e);
        }

        private void codigo_bx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarNumeros(e);
        }
    }
}
