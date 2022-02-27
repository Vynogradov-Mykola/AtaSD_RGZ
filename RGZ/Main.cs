using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ
{
    public partial class RGZ : Form
    {
        public RGZ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LR1.LR1 form = new LR1.LR1();
            form.Show();
        }

        private void Lr2_Click(object sender, EventArgs e)
        {
            LR2.LR2 form = new LR2.LR2();
            form.Show();
        }

        private void Lr3_Click(object sender, EventArgs e)
        {
            LR3.LR3 form = new LR3.LR3();
            form.Show();
        }

        private void Lr4_Click(object sender, EventArgs e)
        {
            LR4.LR4 form = new LR4.LR4();
            form.Show();
        }

        private void LR5_Click(object sender, EventArgs e)
        {
            LR5.LR5 form = new LR5.LR5();
            form.Show();
        }

        private void LR6_Click(object sender, EventArgs e)
        {
            LR6.LR6 form = new LR6.LR6();
            form.Show();
        }

        private void LR7_Click(object sender, EventArgs e)
        {
            LR7.LR7 form = new LR7.LR7();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Vynogradov-Mykola/AtaSD_RGZ");

        }
    }
}
