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
    public partial class catalog_frm : Form
    {
        MySqlConnection conexion = new MySqlConnection("SERVER=localhost; DATABASE=prestamos; UID=root; PASSWORD=chuyon12;");
        private MySqlCommand cmd;
        private MySqlCommandBuilder cmBuilder;
        private MySqlDataAdapter da;
        private DataSet ds;
        private DataTable dt;
        private DataRow dr;
        public Label[] disp_lb = new Label[18];
        
        public catalog_frm()
        {
            
        string buscar = "select Disponible from laptops";
            Buscar(buscar);
            
            InitializeComponent();
        }
        public void Buscar(string consulta)
        {
           bool resultado;

            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

           


            for (int i = 0; i < 18; i++)
            {



                resultado = Convert.ToBoolean(dt.Rows[i][0]);
                disp_lb[i] = new Label();
                if (resultado)
                {
                    
                    disp_lb[i].Text = "Disponible";
                    disp_lb[i].ForeColor = Color.Green;
                    

                }
                else
                {
                  
                    disp_lb[i].Text = "No Disponible";
                    disp_lb[i].ForeColor = Color.Crimson;

                    
                }
            }

            conexion.Close();
            int k = 0;
            for (int j = 1; j < 4; j++)
            {
                for (int i = 1; i < 7; i++)
                {

                    if (j == 1) { disp_lb[k].Location = new Point(150 * i, 206); }
                    else if(j==2) { disp_lb[k].Location = new Point(150 * i, 350); }
                    else { disp_lb[k].Location = new Point(150 * i, 490); }
                    disp_lb[k].Size = new Size(100, 15);
                    disp_lb[k].BackColor = Color.AliceBlue;
                    
                    k++;
                }

            }
            panel1 = new Panel();
            
            this.Controls.AddRange(disp_lb);


        }
        public Boolean Actualizar(String consulta)
        {
            int rows;
            bool agregado = false;

            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                agregado = true;
            }

            conexion.Close();

            return agregado;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void so_lbl2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=1";
            Actualizar(comando);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=2";
            if (Actualizar(comando)) {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=3";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=4";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=5";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=6";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=7";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=8";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=9";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=10";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=11";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=12";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=13";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=14";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=15";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=16";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=17";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string comando = "update laptops set Disponible=false where ID=18";
            if (Actualizar(comando))
            {
                MessageBox.Show("Prestamo Listo");
                this.Close();
            }
            else
            {
                MessageBox.Show("A ocurrido un error");
            }
        }
    }
}
