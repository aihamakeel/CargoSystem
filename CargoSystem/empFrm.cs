using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoSystem
{
    public partial class empFrm : Form
    {
        public empFrm()
        {
            InitializeComponent();
        }

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
    }
}
