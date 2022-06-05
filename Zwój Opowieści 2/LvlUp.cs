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
    public partial class LvlUp : Form
    {
        public LvlUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Form1.player.strenght_points *= 1.05f;
            }
            else if(radioButton2.Checked)
            {
                Form1.player.mana_points *= 1.05f;
            }
            else if (radioButton3.Checked)
            {
                Form1.player.maxcapacity += 1f;
            }
            else
            {
                Form1.player.max_life =(int)(Form1.player.max_life*1.05f);
            }
        }
    }
}
