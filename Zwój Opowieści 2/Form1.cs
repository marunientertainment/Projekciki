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
    public partial class Form1 : Form
    {
        Left_Vilages lok = new Left_Vilages("nazwa", "opis", 2,false);
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly=true;
            richTextBox2.ReadOnly = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<MyObject> list = new List<MyObject>();
            list.Add(lok.generate());
            //richTextBox1.Text = typeof(list[0]).ToString();
            if (list[0].GetType().Name == "Enemy")
            {
                Enemy jedrek = (Enemy)list[0];
                richTextBox1.Text += jedrek.Indroduce() + "\n";
            }
            else if (list[0].GetType().Name == "Item")
            {
                Item jedrekk = (Item)list[0];
                richTextBox1.Text += jedrekk.Introduce() + "\n";
            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
