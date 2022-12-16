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
        Tahac nakladak;

        private void button1_Click(object sender, EventArgs e)
        {
            nakladak = new Tahac(maskedTextBox1.Text, (short)numericUpDown1.Value, (short)numericUpDown4.Value);
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            nakladak.NalozNaklad((short)numericUpDown2.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nakladak.VylozNaklad((short)numericUpDown3.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
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

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.LawnGreen;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Gold;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.LawnGreen;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Gold;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.LawnGreen;
        }

       
    }
}
