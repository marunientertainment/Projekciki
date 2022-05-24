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
        Left_Vilages lok = new Left_Vilages("nazwa", "opis", 2);
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly=true;
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            List<MyObject> list = new List<MyObject>();
            list.Add(lok.generate());
            //richTextBox1.Text = typeof(list[0]).ToString();
            if(list[0].GetType().Name =="Enemy")
            {
                Enemy jedrek = (Enemy)list[0];
                richTextBox1.Text=jedrek.Indroduce();
            }
            else if(list[0].GetType().Name == "Item")
            {
                Item jedrekk=(Item)list[0];
                richTextBox1.Text = jedrekk.Introduce();
            }
        }
    }
}
