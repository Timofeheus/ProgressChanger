using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgressChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void minus1_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = progressBar1.Value - 1;
                PRMetr.Text = progressBar1.Value.ToString() + "%";
                BTInf.Text = "-1% of Progress";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                progressBar1.Value = 0;
                PRMetr.Text = "0%";
                BTInf.Text = "Error!\nProgress < 0";
            }
        }

        private void minus10_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = progressBar1.Value - 10;
                PRMetr.Text = progressBar1.Value.ToString() + "%";
                BTInf.Text = "-10% of Progress";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                progressBar1.Value = 0;
                PRMetr.Text = "0%";
                BTInf.Text = "Error!\nProgress < 0";
            }
        }

        private void minus50_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = progressBar1.Value - 50;
                PRMetr.Text = progressBar1.Value.ToString() + "%";
                BTInf.Text = "-50% of Progress";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                progressBar1.Value = 0;
                PRMetr.Text = "0%";
                BTInf.Text = "Error!\nProgress < 0";
            }
        }

        private void plus1_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = progressBar1.Value + 1;
                PRMetr.Text = progressBar1.Value.ToString() + "%";
                BTInf.Text = "+1% of Progress";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                progressBar1.Value = 100;
                PRMetr.Text = "100%";
                BTInf.Text = "Error!\nProgress > 100";
            }
        }

        private void plus10_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = progressBar1.Value + 10;
                PRMetr.Text = progressBar1.Value.ToString() + "%";
                BTInf.Text = "+10% of Progress";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                progressBar1.Value = 100;
                PRMetr.Text = "100%";
                BTInf.Text = "Error!\nProgress > 100";
            }
        }

        private void plus50_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = progressBar1.Value + 50;
                PRMetr.Text = progressBar1.Value.ToString() + "%";
                BTInf.Text = "+50% of Progress";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                progressBar1.Value = 100;
                PRMetr.Text = "100%";
                BTInf.Text = "Error!\nProgress > 100";
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author - vk.com/timofeheus");
        }
    }
}