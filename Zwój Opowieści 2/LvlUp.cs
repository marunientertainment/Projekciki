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
                this.Close();
            }
            else if(radioButton2.Checked)
            {
                Form1.player.mana_points *= 1.05f;
                if(Form1.player.mana_consumption>0.1f)
                {
                    Form1.player.mana_consumption -= 0.05f;
                }
                this.Close();
            }
            else if (radioButton3.Checked)
            {
                Form1.player.maxcapacity += 1f;
                this.Close();
            }
            else
            {
                Form1.player.max_life =(int)Math.Ceiling(Form1.player.max_life*1.05f);
                Form1.player.life = (int)Form1.player.max_life;
                this.Close();
            }
        }
    }
}
