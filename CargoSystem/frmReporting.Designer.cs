namespace CargoSystem
{
    partial class frmReporting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOdrUncomp = new System.Windows.Forms.Button();
            this.btnOdrComp = new System.Windows.Forms.Button();
            this.btnCusRpt = new System.Windows.Forms.Button();
            this.btnTrkRpt = new System.Windows.Forms.Button();
            this.btnDrvrRpt = new System.Windows.Forms.Button();
            this.btnOdrRpt = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMaxs = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnDrvrAvbl = new System.Windows.Forms.Button();
            this.btnDrvrUnAvbl = new System.Windows.Forms.Button();
            this.btnTrkAvbl = new System.Windows.Forms.Button();
            this.btnTrkUnAvbl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTrkUnAvbl);
            this.panel1.Controls.Add(this.btnTrkAvbl);
            this.panel1.Controls.Add(this.btnDrvrUnAvbl);
            this.panel1.Controls.Add(this.btnDrvrAvbl);
            this.panel1.Controls.Add(this.btnOdrUncomp);
            this.panel1.Controls.Add(this.btnOdrComp);
            this.panel1.Controls.Add(this.btnCusRpt);
            this.panel1.Controls.Add(this.btnTrkRpt);
            this.panel1.Controls.Add(this.btnDrvrRpt);
            this.panel1.Controls.Add(this.btnOdrRpt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 596);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporting Window";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-1, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 6);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 37);
            this.panel2.TabIndex = 1;
            // 
            // btnOdrUncomp
            // 
            this.btnOdrUncomp.FlatAppearance.BorderSize = 0;
            this.btnOdrUncomp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdrUncomp.ForeColor = System.Drawing.Color.White;
            this.btnOdrUncomp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdrUncomp.Location = new System.Drawing.Point(10, 356);
            this.btnOdrUncomp.Name = "btnOdrUncomp";
            this.btnOdrUncomp.Size = new System.Drawing.Size(186, 37);
            this.btnOdrUncomp.TabIndex = 1;
            this.btnOdrUncomp.Text = "Uncompleted Orders";
            this.btnOdrUncomp.UseVisualStyleBackColor = true;
            this.btnOdrUncomp.Click += new System.EventHandler(this.btnOdrUncomp_Click);
            // 
            // btnOdrComp
            // 
            this.btnOdrComp.FlatAppearance.BorderSize = 0;
            this.btnOdrComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdrComp.ForeColor = System.Drawing.Color.White;
            this.btnOdrComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdrComp.Location = new System.Drawing.Point(10, 302);
            this.btnOdrComp.Name = "btnOdrComp";
            this.btnOdrComp.Size = new System.Drawing.Size(186, 48);
            this.btnOdrComp.TabIndex = 1;
            this.btnOdrComp.Text = "Completed Orders";
            this.btnOdrComp.UseVisualStyleBackColor = true;
            this.btnOdrComp.Click += new System.EventHandler(this.btnOdrComp_Click);
            // 
            // btnCusRpt
            // 
            this.btnCusRpt.FlatAppearance.BorderSize = 0;
            this.btnCusRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusRpt.ForeColor = System.Drawing.Color.White;
            this.btnCusRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusRpt.Location = new System.Drawing.Point(10, 259);
            this.btnCusRpt.Name = "btnCusRpt";
            this.btnCusRpt.Size = new System.Drawing.Size(186, 37);
            this.btnCusRpt.TabIndex = 1;
            this.btnCusRpt.Text = "Customers Report";
            this.btnCusRpt.UseVisualStyleBackColor = true;
            this.btnCusRpt.Click += new System.EventHandler(this.btnCusRpt_Click);
            // 
            // btnTrkRpt
            // 
            this.btnTrkRpt.FlatAppearance.BorderSize = 0;
            this.btnTrkRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrkRpt.ForeColor = System.Drawing.Color.White;
            this.btnTrkRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrkRpt.Location = new System.Drawing.Point(10, 216);
            this.btnTrkRpt.Name = "btnTrkRpt";
            this.btnTrkRpt.Size = new System.Drawing.Size(186, 37);
            this.btnTrkRpt.TabIndex = 1;
            this.btnTrkRpt.Text = "Trucks Report";
            this.btnTrkRpt.UseVisualStyleBackColor = true;
            this.btnTrkRpt.Click += new System.EventHandler(this.btnTrkRpt_Click);
            // 
            // btnDrvrRpt
            // 
            this.btnDrvrRpt.FlatAppearance.BorderSize = 0;
            this.btnDrvrRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrvrRpt.ForeColor = System.Drawing.Color.White;
            this.btnDrvrRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrvrRpt.Location = new System.Drawing.Point(10, 173);
            this.btnDrvrRpt.Name = "btnDrvrRpt";
            this.btnDrvrRpt.Size = new System.Drawing.Size(186, 37);
            this.btnDrvrRpt.TabIndex = 1;
            this.btnDrvrRpt.Text = "Drivers Report";
            this.btnDrvrRpt.UseVisualStyleBackColor = true;
            this.btnDrvrRpt.Click += new System.EventHandler(this.btnDrvrRpt_Click);
            // 
            // btnOdrRpt
            // 
            this.btnOdrRpt.FlatAppearance.BorderSize = 0;
            this.btnOdrRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdrRpt.ForeColor = System.Drawing.Color.White;
            this.btnOdrRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdrRpt.Location = new System.Drawing.Point(10, 130);
            this.btnOdrRpt.Name = "btnOdrRpt";
            this.btnOdrRpt.Size = new System.Drawing.Size(186, 37);
            this.btnOdrRpt.TabIndex = 1;
            this.btnOdrRpt.Tag = "Order";
            this.btnOdrRpt.Text = "View Orders && Report";
            this.btnOdrRpt.UseVisualStyleBackColor = true;
            this.btnOdrRpt.Click += new System.EventHandler(this.btnOdrRpt_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.btnMax);
            this.panel4.Controls.Add(this.btnMaxs);
            this.panel4.Controls.Add(this.btnMin);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(196, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1037, 33);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(207)))), ((int)(((byte)(85)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1004, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(207)))), ((int)(((byte)(85)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(962, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(27, 27);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMaxs
            // 
            this.btnMaxs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxs.FlatAppearance.BorderSize = 0;
            this.btnMaxs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(207)))), ((int)(((byte)(85)))));
            this.btnMaxs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxs.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxs.Image")));
            this.btnMaxs.Location = new System.Drawing.Point(962, 3);
            this.btnMaxs.Name = "btnMaxs";
            this.btnMaxs.Size = new System.Drawing.Size(27, 27);
            this.btnMaxs.TabIndex = 1;
            this.btnMaxs.UseVisualStyleBackColor = true;
            this.btnMaxs.Visible = false;
            this.btnMaxs.Click += new System.EventHandler(this.btnMaxs_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(207)))), ((int)(((byte)(85)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(920, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(27, 27);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnDrvrAvbl
            // 
            this.btnDrvrAvbl.FlatAppearance.BorderSize = 0;
            this.btnDrvrAvbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrvrAvbl.ForeColor = System.Drawing.Color.White;
            this.btnDrvrAvbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrvrAvbl.Location = new System.Drawing.Point(10, 399);
            this.btnDrvrAvbl.Name = "btnDrvrAvbl";
            this.btnDrvrAvbl.Size = new System.Drawing.Size(186, 37);
            this.btnDrvrAvbl.TabIndex = 1;
            this.btnDrvrAvbl.Text = "Available Drivers";
            this.btnDrvrAvbl.UseVisualStyleBackColor = true;
            this.btnDrvrAvbl.Click += new System.EventHandler(this.btnDrvrAvbl_Click);
            // 
            // btnDrvrUnAvbl
            // 
            this.btnDrvrUnAvbl.FlatAppearance.BorderSize = 0;
            this.btnDrvrUnAvbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrvrUnAvbl.ForeColor = System.Drawing.Color.White;
            this.btnDrvrUnAvbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrvrUnAvbl.Location = new System.Drawing.Point(10, 442);
            this.btnDrvrUnAvbl.Name = "btnDrvrUnAvbl";
            this.btnDrvrUnAvbl.Size = new System.Drawing.Size(186, 37);
            this.btnDrvrUnAvbl.TabIndex = 1;
            this.btnDrvrUnAvbl.Text = "Unavailable Drivers";
            this.btnDrvrUnAvbl.UseVisualStyleBackColor = true;
            this.btnDrvrUnAvbl.Click += new System.EventHandler(this.btnDrvrUnAvbl_Click);
            // 
            // btnTrkAvbl
            // 
            this.btnTrkAvbl.FlatAppearance.BorderSize = 0;
            this.btnTrkAvbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrkAvbl.ForeColor = System.Drawing.Color.White;
            this.btnTrkAvbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrkAvbl.Location = new System.Drawing.Point(10, 485);
            this.btnTrkAvbl.Name = "btnTrkAvbl";
            this.btnTrkAvbl.Size = new System.Drawing.Size(186, 37);
            this.btnTrkAvbl.TabIndex = 1;
            this.btnTrkAvbl.Text = "Available Trucks";
            this.btnTrkAvbl.UseVisualStyleBackColor = true;
            this.btnTrkAvbl.Click += new System.EventHandler(this.btnTrkAvbl_Click);
            // 
            // btnTrkUnAvbl
            // 
            this.btnTrkUnAvbl.FlatAppearance.BorderSize = 0;
            this.btnTrkUnAvbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrkUnAvbl.ForeColor = System.Drawing.Color.White;
            this.btnTrkUnAvbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrkUnAvbl.Location = new System.Drawing.Point(10, 528);
            this.btnTrkUnAvbl.Name = "btnTrkUnAvbl";
            this.btnTrkUnAvbl.Size = new System.Drawing.Size(186, 37);
            this.btnTrkUnAvbl.TabIndex = 1;
            this.btnTrkUnAvbl.Text = "Unavailable Trucks";
            this.btnTrkUnAvbl.UseVisualStyleBackColor = true;
            this.btnTrkUnAvbl.Click += new System.EventHandler(this.btnTrkUnAvbl_Click);
            // 
            // frmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 596);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporting Window";
            this.Load += new System.EventHandler(this.frmReporting_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOdrUncomp;
        private System.Windows.Forms.Button btnOdrComp;
        private System.Windows.Forms.Button btnCusRpt;
        private System.Windows.Forms.Button btnTrkRpt;
        private System.Windows.Forms.Button btnDrvrRpt;
        private System.Windows.Forms.Button btnOdrRpt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMaxs;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnTrkUnAvbl;
        private System.Windows.Forms.Button btnTrkAvbl;
        private System.Windows.Forms.Button btnDrvrUnAvbl;
        private System.Windows.Forms.Button btnDrvrAvbl;
    }
}