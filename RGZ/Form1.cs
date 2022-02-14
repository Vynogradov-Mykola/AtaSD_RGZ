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
    }
}
