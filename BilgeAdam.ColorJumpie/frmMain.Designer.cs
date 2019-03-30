namespace BilgeAdam.ColorJumpie
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnl0 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.btnCEE = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnl0
            // 
            this.pnl0.Location = new System.Drawing.Point(12, 12);
            this.pnl0.Name = "pnl0";
            this.pnl0.Size = new System.Drawing.Size(83, 82);
            this.pnl0.TabIndex = 0;
            this.pnl0.Tag = "colorable";
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(101, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(83, 82);
            this.pnl1.TabIndex = 1;
            this.pnl1.Tag = "colorable";
            // 
            // pnl3
            // 
            this.pnl3.Location = new System.Drawing.Point(279, 12);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(83, 82);
            this.pnl3.TabIndex = 3;
            this.pnl3.Tag = "colorable";
            // 
            // pnl5
            // 
            this.pnl5.Location = new System.Drawing.Point(457, 12);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(83, 82);
            this.pnl5.TabIndex = 2;
            this.pnl5.Tag = "colorable";
            // 
            // pnl2
            // 
            this.pnl2.Location = new System.Drawing.Point(190, 12);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(83, 82);
            this.pnl2.TabIndex = 5;
            this.pnl2.Tag = "colorable";
            // 
            // pnl4
            // 
            this.pnl4.Location = new System.Drawing.Point(368, 12);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(83, 82);
            this.pnl4.TabIndex = 4;
            this.pnl4.Tag = "colorable";
            // 
            // btnCEE
            // 
            this.btnCEE.Location = new System.Drawing.Point(457, 100);
            this.btnCEE.Name = "btnCEE";
            this.btnCEE.Size = new System.Drawing.Size(83, 23);
            this.btnCEE.TabIndex = 6;
            this.btnCEE.Text = "CE";
            this.btnCEE.UseVisualStyleBackColor = true;
            this.btnCEE.Click += new System.EventHandler(this.btnCEE_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 300;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 135);
            this.Controls.Add(this.btnCEE);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.pnl0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renk Atlatmaca";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl0;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Button btnCEE;
        private System.Windows.Forms.Timer tmr;
    }
}

