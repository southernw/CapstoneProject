using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace CapstoneProject
{
    public partial class MainForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBoderButton;
        private Form currentChildForm;
        


        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1650, 800);
            //this.MaximumSize = new Size(1650, 800);
            leftBoderButton = new Panel();
            //leftBoderButton.Size = new Size(10, 60);
            panelMenu.Controls.Add(leftBoderButton);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.DoubleBuffered = true ;
            this.MaximizedBounds = Screen.FromHandle(Handle).WorkingArea; //Fix window full screen resize
            //this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Text = "Welcome to the Single Well Evaluation Tool \n" +
                "*To get started, choose an option from the menu";

            Color color = System.Drawing.ColorTranslator.FromHtml("#f9f6f1");
            this.btnHome.ForeColor = Color.Gray;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#f9f6f1");
            this.btnHome.ForeColor = Color.Gray;
            this.btnGas.ForeColor = color;
            this.btnOil.ForeColor = color;
            this.btnCashFlow.ForeColor = color;
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new FormGas());
            Color color = System.Drawing.ColorTranslator.FromHtml("#f9f6f1");
            this.btnGas.ForeColor = Color.Gray;
            this.btnHome.ForeColor = color;
            this.btnOil.ForeColor = color;
            this.btnCashFlow.ForeColor = color;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#f9f6f1");
            OpenChildForm(new FormOil());
            this.btnOil.ForeColor = Color.Gray;
            this.btnHome.ForeColor = color;
            this.btnGas.ForeColor = color;
            this.btnCashFlow.ForeColor = color;

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#f9f6f1");
            FormCashFlow cashFlow = new FormCashFlow();
            this.WindowState = FormWindowState.Maximized;
            this.btnCashFlow.ForeColor = Color.Gray;
            this.btnHome.ForeColor = color;
            this.btnOil.ForeColor = color;
            this.btnGas.ForeColor = color;
            OpenChildForm(cashFlow);
            

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1585, 888);
           
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill ;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //childForm.WindowState = FormWindowState.Maximized;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {

            const string message =
        "Are you sure that you would like to exit the program?";
            const string caption = "Exit?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

