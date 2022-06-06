using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zwój_Opowieści_2
{
    public partial class SelectingLvl : Form
    {
        public SelectingLvl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1.current_location = 0;
                //Form1.richTextBox1.Text += "Wchodzisz do " + Form1.selector.Name(Form1.current_location) + "\n";
                this.Close();
            }
            else if (radioButton2.Checked)
            {
                Form1.current_location = 1;
                this.Close();
            }
            else if (radioButton3.Checked)
            {
                Form1.current_location = 2;
                this.Close();
            }
            else if (radioButton4.Checked)
            {
                Form1.current_location = 3;
                this.Close();
            }
            else if (radioButton5.Checked)
            {
                Form1.current_location = 4;
                this.Close();
            }
            else if (radioButton6.Checked)
            {
                Form1.current_location = 5;
                this.Close();
            }
            else if (radioButton7.Checked)
            {
                Form1.current_location = 6;
                this.Close();
            }
            else
            {
                Form1.current_location = 7;
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text= Form1.selector.Description(0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.selector.Description(1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.selector.Description(2);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.selector.Description(3);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.selector.Description(4);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.selector.Description(5);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.selector.Description(6);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.selector.Description(7);
        }
    }
}
