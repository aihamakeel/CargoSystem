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
    public partial class frmReporting : Form
    {
        public frmReporting()
        {
            InitializeComponent();
        }
        int LX, LY, SW, SH;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOdrRpt_Click(object sender, EventArgs e)
        {
            panel2.Top = btnOdrRpt.Top;
        }

        private void btnDrvrRpt_Click(object sender, EventArgs e)
        {
            panel2.Top = btnDrvrRpt.Top;
        }

        private void btnTrkRpt_Click(object sender, EventArgs e)
        {
            panel2.Top = btnTrkRpt.Top;
        }

        private void btnCusRpt_Click(object sender, EventArgs e)
        {
            panel2.Top = btnCusRpt.Top;
        }

        private void btnOdrComp_Click(object sender, EventArgs e)
        {
            panel2.Top = btnOdrComp.Top;
        }

        private void btnOdrUncomp_Click(object sender, EventArgs e)
        {
            panel2.Top = btnOdrUncomp.Top;
        }

        private void btnDrvrAvbl_Click(object sender, EventArgs e)
        {
            panel2.Top = btnDrvrAvbl.Top;
        }

        private void btnDrvrUnAvbl_Click(object sender, EventArgs e)
        {
            panel2.Top = btnDrvrUnAvbl.Top;
        }

        private void btnTrkAvbl_Click(object sender, EventArgs e)
        {
            panel2.Top = btnTrkAvbl.Top;
        }

        private void btnTrkUnAvbl_Click(object sender, EventArgs e)
        {
            panel2.Top = btnTrkUnAvbl.Top;
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

        private void frmReporting_Load(object sender, EventArgs e)
        {

        }
    }
}
