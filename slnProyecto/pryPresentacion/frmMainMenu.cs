using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;
using pryPresentacion.Forms;

namespace pryPresentacion
{
    public partial class frmMainMenu : Form
    {
        //CAMPOS PRIVADOS
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public frmMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBorderBtn);
            //FORM
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        private struct RGBColors 
        {
            public static Color Color1 = Color.FromArgb(95,77,221);//morado
            public static Color Color2 = Color.FromArgb(24, 161, 251);//celeste
            public static Color Color3 = Color.FromArgb(249, 88, 155); //rosada
            public static Color Color4 = Color.FromArgb(253, 138, 114); //anaranjado

        }

        //METODOS
        private void ActivateButton(object senderBtn, Color color) 
        {
            if (senderBtn != null) 
            {
                DisableButton();
                //BOTÓN
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //BORDE IZQUIERDO - BOTON
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //ICON CURRENT CHILD FORM
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color; 

            }
        }
        //Desactivar el resaltao del botón
        private void DisableButton() 
        {
            if (currentBtn != null) 
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm) 
        {
            if (currentChildForm!=null) 
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }


        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color1);
            OpenChildForm(new frmCita());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color2);
            OpenChildForm(new frmRegistrarP());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset() 
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.LightGray;
            lblTitleChildForm.Text = "Home";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]//permite mover el formulario a travez del evento del mouse.
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color4);
            //OpenChildForm(new InformeVentasPorProducto());
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
