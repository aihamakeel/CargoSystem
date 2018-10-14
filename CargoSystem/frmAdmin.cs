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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        int LX, LY, SW, SH;

        private void btnMax_Click(object sender, EventArgs e)
        {
            //LX = this.Location.X;
            //LY = this.Location.Y;
            //SW = this.Size.Width;
            //SH = this.Size.Height;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.WindowState = FormWindowState.Maximized;
            btnMaxs.Visible = true;
            btnMax.Visible = false;
        }

        private void btnMaxs_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            //this.Size = new Size(SW, SH);
            //this.Location = new Point(LX, LY);
            btnMaxs.Visible = false;
            btnMax.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOdrAgree_Click(object sender, EventArgs e)
        {
            panel2.Top = btnOdrAgree.Top;
        }

        private void btnDrvrChos_Click(object sender, EventArgs e)
        {
            panel2.Top = btnDrvrChos.Top;
        }

        private void btnOdrEdt_Click(object sender, EventArgs e)
        {
            panel2.Top = btnOdrEdt.Top;
        }

        private void btnNewUsr_Click(object sender, EventArgs e)
        {
            panel2.Top = btnNewUsr.Top;
        }

        private void btnUsrMng_Click(object sender, EventArgs e)
        {
            panel2.Top = btnUsrMng.Top;
        }

        private void btnReprt_Click(object sender, EventArgs e)
        {
            panel2.Top = btnReprt.Top;
            frmReporting frmReporting = new frmReporting();
            frmReporting.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void frmAdmin_MaximumSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAdmin_MinimumSizeChanged(object sender, EventArgs e)
        {
         
        }

        private void frmAdmin_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
