namespace ProgressChanger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.minus1 = new System.Windows.Forms.Button();
            this.plus1 = new System.Windows.Forms.Button();
            this.minus10 = new System.Windows.Forms.Button();
            this.plus10 = new System.Windows.Forms.Button();
            this.minus50 = new System.Windows.Forms.Button();
            this.plus50 = new System.Windows.Forms.Button();
            this.PRMetr = new System.Windows.Forms.Label();
            this.BTInf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 30);
            // 
            // minus1
            // 
            this.minus1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.minus1.ForeColor = System.Drawing.Color.White;
            this.minus1.Location = new System.Drawing.Point(3, 36);
            this.minus1.Name = "minus1";
            this.minus1.Size = new System.Drawing.Size(65, 47);
            this.minus1.TabIndex = 1;
            this.minus1.Text = "-1%";
            this.minus1.Click += new System.EventHandler(this.minus1_Click);
            // 
            // plus1
            // 
            this.plus1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.plus1.ForeColor = System.Drawing.Color.White;
            this.plus1.Location = new System.Drawing.Point(180, 36);
            this.plus1.Name = "plus1";
            this.plus1.Size = new System.Drawing.Size(65, 47);
            this.plus1.TabIndex = 2;
            this.plus1.Text = "+1%";
            this.plus1.Click += new System.EventHandler(this.plus1_Click);
            // 
            // minus10
            // 
            this.minus10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minus10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.minus10.ForeColor = System.Drawing.Color.White;
            this.minus10.Location = new System.Drawing.Point(3, 89);
            this.minus10.Name = "minus10";
            this.minus10.Size = new System.Drawing.Size(65, 47);
            this.minus10.TabIndex = 3;
            this.minus10.Text = "-10%";
            this.minus10.Click += new System.EventHandler(this.minus10_Click);
            // 
            // plus10
            // 
            this.plus10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plus10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.plus10.ForeColor = System.Drawing.Color.White;
            this.plus10.Location = new System.Drawing.Point(180, 89);
            this.plus10.Name = "plus10";
            this.plus10.Size = new System.Drawing.Size(65, 47);
            this.plus10.TabIndex = 4;
            this.plus10.Text = "+10%";
            this.plus10.Click += new System.EventHandler(this.plus10_Click);
            // 
            // minus50
            // 
            this.minus50.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minus50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.minus50.ForeColor = System.Drawing.Color.White;
            this.minus50.Location = new System.Drawing.Point(3, 142);
            this.minus50.Name = "minus50";
            this.minus50.Size = new System.Drawing.Size(65, 47);
            this.minus50.TabIndex = 5;
            this.minus50.Text = "-50%";
            this.minus50.Click += new System.EventHandler(this.minus50_Click);
            // 
            // plus50
            // 
            this.plus50.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plus50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.plus50.ForeColor = System.Drawing.Color.White;
            this.plus50.Location = new System.Drawing.Point(180, 142);
            this.plus50.Name = "plus50";
            this.plus50.Size = new System.Drawing.Size(65, 47);
            this.plus50.TabIndex = 6;
            this.plus50.Text = "+50%";
            this.plus50.Click += new System.EventHandler(this.plus50_Click);
            // 
            // PRMetr
            // 
            this.PRMetr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PRMetr.Location = new System.Drawing.Point(74, 33);
            this.PRMetr.Name = "PRMetr";
            this.PRMetr.Size = new System.Drawing.Size(100, 17);
            this.PRMetr.Text = "Progressmetr";
            this.PRMetr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTInf
            // 
            this.BTInf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTInf.Location = new System.Drawing.Point(74, 50);
            this.BTInf.Name = "BTInf";
            this.BTInf.Size = new System.Drawing.Size(100, 33);
            this.BTInf.Text = "Much % -/+";
            this.BTInf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(0, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.Text = "(C) Timoha Timohavich";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.Location = new System.Drawing.Point(224, 194);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(24, 19);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.Text = "VK";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(248, 213);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTInf);
            this.Controls.Add(this.PRMetr);
            this.Controls.Add(this.plus50);
            this.Controls.Add(this.minus50);
            this.Controls.Add(this.plus10);
            this.Controls.Add(this.minus10);
            this.Controls.Add(this.plus1);
            this.Controls.Add(this.minus1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "#ProgressChanger v1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button minus1;
        private System.Windows.Forms.Button plus1;
        private System.Windows.Forms.Button minus10;
        private System.Windows.Forms.Button plus10;
        private System.Windows.Forms.Button minus50;
        private System.Windows.Forms.Button plus50;
        private System.Windows.Forms.Label PRMetr;
        private System.Windows.Forms.Label BTInf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}

