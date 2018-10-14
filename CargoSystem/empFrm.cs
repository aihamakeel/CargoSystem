using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CargoSystem
{
    public partial class empFrm : Form
    {
        public empFrm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

         int LX, LY, SW, SH;
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnNewOdr_Click(object sender, EventArgs e)
        {
            panel2.Top  = btnOdr.Top ;     
        }

        private void btnOdrMng_Click(object sender, EventArgs e)
        {
            panel2.Top  = btnOdrMng.Top ;
        }

        private void btnOdrFnsh_Click(object sender, EventArgs e)
        {
            panel2.Top = btnOdrFnsh.Top;
        }

        private void btnDrvr_Click(object sender, EventArgs e)
        {
            panel2.Top = btnDrvr.Top;
        }

        private void btnDrvrMng_Click(object sender, EventArgs e)
        {
            panel2.Top = btnDrvrMng.Top;
        }

        private void btnDrvrRat_Click(object sender, EventArgs e)
        {
            panel2.Top = btnDrvrRat.Top;
        }

        private void btnTrk_Click(object sender, EventArgs e)
        {
            panel2.Top = btnTrk.Top;
        }

        private void btnTrkMng_Click(object sender, EventArgs e)
        {
            panel2.Top = btnTrkMng.Top;
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            panel2.Top = btnCus.Top;
        }

        private void btnCusMng_Click(object sender, EventArgs e)
        {
            panel2.Top = btnCusMng.Top;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        //Window Movment
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            //Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.WindowState = FormWindowState.Maximized;
            btnMaxs.Visible = true;
            btnMax.Visible = false;
        }

        private void btnMaxs_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            btnMaxs.Visible = false;
            btnMax.Visible = true;
        }
    }
}
