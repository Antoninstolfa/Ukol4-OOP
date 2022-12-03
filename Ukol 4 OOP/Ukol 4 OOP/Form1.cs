using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol_4_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NakladniAuto nakladak = new NakladniAuto(maskedTextBox1.Text, (short)numericUpDown1.Value);
            nakladak.NalozNaklad((short)numericUpDown2.Value);
            nakladak.VylozNaklad((short)numericUpDown3.Value);
            odpoved.Text = nakladak.ToString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }
    }
}
