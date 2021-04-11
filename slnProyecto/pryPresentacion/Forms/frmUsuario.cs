using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Runtime.InteropServices;


using pryPresentacion.Modelo;

namespace pryPresentacion.Forms
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        db_clinicEntities db = new db_clinicEntities();
        tb_receptionist tb_r = new tb_receptionist();
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
        }

        private void btningresar_Click_1(object sender, EventArgs e)
        {
            var listar = (from tb_r in db.tb_receptionist
                          where tb_r.dni == txtusu.Text && tb_r.password == txtcontra.Text
                          select tb_r.dni).ToList();
            if (listar.Count() > 0)
            {

                var v_id = (from tb_r in db.tb_receptionist
                              where tb_r.dni == txtusu.Text 
                              select tb_r.id).ToList();

                Class.Usuario.usu =Convert.ToString(v_id.First());

                frmMainMenu main = new frmMainMenu();
                main.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("El Dato Ingresados es Incorrecto");
            }

            txtcontra.Clear();
            txtusu.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcontra.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcontra.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcontra.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtcontra.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtcontra.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtcontra.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtcontra.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtcontra.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtcontra.Text += "9";
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtcontra.Clear();
            txtusu.Clear();
        }
    }
}
