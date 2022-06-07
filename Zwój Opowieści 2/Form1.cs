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
        int step = 1;
        public static int current_location =0;
        Random rand = new Random();
        public static Selector selector = new Selector();
        //List<Item> item_list = new List<Item>();//for balance 
        List<MyObject> object_list = new List<MyObject>();//balance
        //List<Enemy> enemy_list = new List<Enemy>();//for balance
        public static Player player = new Player(100,100);

        public void Life_Update()
        {
            progressBar1.Value = (int)((((float)player.life) / player.max_life) * 100);//life bar
            label1.Text = player.life + "/" + player.max_life + " Życie";//life label
        }

        public void Mana_Update()
        {
            progressBar2.Value = (int)(((float)player.mana / (float)(player.max_mana)) * 100);//mana bar
            label2.Text = player.mana + "/" + player.max_mana + " Mana";//mana label
        }

        public void Xp_Update()
        {
            progressBar3.Value = (int)(((float)player.Xp / (float)(player.lvl * 50)) * 100);//xp bar
            label8.Text = player.Xp + "/" + player.lvl * 50 + " Poziom " + player.lvl;//xp label
        }

        public void Backpack_Update()
        {
            label6.Text = "Miejsce w plecaku " + player.capacity() + "/" + player.maxcapacity + " Kg ";//backpack capacity label
        }

        public void Reset()
        {
            player.backpack.Clear();
            player.life = 100;
            player.life_points = 1;
            player.mana = 100;
            player.mana_points = 1;
            player.maxcapacity = 5;
            player.max_life = 100;
            player.max_mana = 100;
            player.strenght_points = 1;
            player.Xp = 0;
            player.lvl = 1;
            player.mana_consumption = 1;
            current_location = 0;
            step = 1;
            richTextBox1.Clear();
            richTextBox2.Clear();
            comboBox1.Items.Clear();
            Weapon sword = new Weapon("Miecz", "opis", 0.1f, 10, 0, 0, false);
            Weapon fireball = new Weapon("księga kuli ognia", "potezne zaklecie wystrzeliwujace kule ognia", 0.2f, 0, 10, 15, true);
            player.backpack.Add(sword);
            player.backpack.Add(fireball);
            foreach (Item item in player.backpack)
            {
                comboBox1.Items.Add(item.name);
            }
            Life_Update();
            Mana_Update();
            Xp_Update();
            Backpack_Update();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly=true;
            richTextBox2.ReadOnly = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Reset();
        }

        private void button1_Click_1(object sender, EventArgs e)//Next
        {            
            if (current_location >=8)
            {
                richTextBox2.Text = "WYGRAŁEŚ!!!";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            
            if (step <= selector.Levels(current_location))
            {
                object_list.Add(selector.Generate(current_location,step));
                richTextBox1.Text += "Krok " + step + "\n";
                if ((player.mana + 5) > player.max_mana)
                {
                    player.mana = player.max_mana;
                }
                else
                {
                    player.mana += 5;
                }
                if (object_list[object_list.Count - 1].GetType().Name == "Enemy")
                {
                    Enemy enemy = (Enemy)object_list.Last();
                    button1.Enabled = false;
                    if (rand.Next(1, 2) == 1)
                    {
                        richTextBox1.Text += enemy.name + " Atakuje cie za " + enemy.damage + "\n";
                        player.life -= enemy.damage;
                    }
                    else
                    {
                        richTextBox1.Text += enemy.name + " została zaskoczona, atakujesz pierwszy" + "\n";
                    }
                }
                else if (object_list[object_list.Count - 1].GetType().Name == "Item")
                {
                    Item item = (Item)object_list.Last();
                    richTextBox1.Text += "Znajdujesz " + item.name + "\n";
                }
                else if (object_list[object_list.Count - 1].GetType().Name == "Weapon")
                {
                    Weapon weapon = (Weapon)object_list.Last();
                    richTextBox1.Text += "Znajdujesz " + weapon.name + "\n";
                }
                else if (object_list[object_list.Count - 1].GetType().Name == "Mixture")
                {
                    Mixture mixture = (Mixture)object_list.Last();
                    richTextBox1.Text += "Znajdujesz " + mixture.name + "\n";
                }
            }
            else
            {
                step = 1;
                SelectingLvl selectingLvl = new SelectingLvl();
                selectingLvl.ShowDialog();
                richTextBox1.Text = "";
                //richTextBox1.Text += "Wchodzisz do " + selector.Name(current_location)+"\n";
            }
            step++;
            button2.Enabled = true;
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }//Main window scroling

        private void button2_Click(object sender, EventArgs e)//take
        {
            if (object_list[object_list.Count - 1].GetType().Name == "Item"|| object_list[object_list.Count - 1].GetType().Name == "Weapon"|| object_list[object_list.Count - 1].GetType().Name == "Mixture")
            {
                if(player.add((Item)object_list[object_list.Count - 1]))
                {
                    player.backpack.Add((Item)object_list[object_list.Count - 1]);
                    button2.Enabled = false;
                    comboBox1.Items.Clear();
                    foreach (Item item in player.backpack)
                    {
                        comboBox1.Items.Add(item.name);
                    }
                }
                else
                {
                    richTextBox1.Text += "Zamało miejsca";
                }
            }
            else
            {
                richTextBox1.Text += "Nie mogę tego podnieść";
            }
        }

        private void button7_Click(object sender, EventArgs e)//restart
        {
            Reset();
        }

        private void button4_Click(object sender, EventArgs e)//use for backpack
        {
            if (comboBox1.SelectedIndex != -1)
            {
                //healing or adding mana
                if (player.backpack[comboBox1.SelectedIndex].GetType().Name=="Mixture")
                {
                    Mixture mixture = (Mixture)player.backpack[comboBox1.SelectedIndex];
                    if(mixture.ismagic)
                    {
                        if ((player.mana + mixture.value) > player.max_mana)
                        {
                            player.mana = player.max_mana;
                        }
                        else
                        {
                            player.mana += mixture.value;
                        }
                    }
                    else
                    {
                        if ((player.life + mixture.value) > player.max_life)
                        {
                            player.life = (int)player.max_life;
                        }
                        else
                        {
                            player.life += mixture.value;
                        }
                    }
                    player.backpack.RemoveAt(comboBox1.SelectedIndex);
                    comboBox1.Items.Clear();
                    foreach (Item item in player.backpack)
                    {
                        comboBox1.Items.Add(item.name);
                    }
                }
                //atack
                else if (player.backpack[comboBox1.SelectedIndex].GetType().Name == "Weapon")
                {
                    if (object_list.Count > 0 && object_list[object_list.Count - 1].GetType().Name == "Enemy")
                    {
                        Enemy enemy =(Enemy)object_list.Last();
                        if (enemy.life>0)
                        {
                            Weapon weapon = (Weapon)player.backpack[comboBox1.SelectedIndex];                            
                            if(weapon.ismagic)
                            {
                                if((player.mana - weapon.consumption)<0)
                                {
                                    richTextBox2.Text = "Zamało many!";
                                }
                                else
                                {
                                    player.mana -= (int)Math.Ceiling(weapon.consumption* player.mana_consumption);
                                    enemy.life -= (int)(weapon.damage * player.mana_points);
                                    richTextBox1.Text += "Za atakowano za " + (int)(weapon.damage * player.mana_points) + "\n";
                                }                    
                            }
                            else
                            {
                                enemy.life -= (int)(weapon.damage * player.strenght_points);
                                richTextBox1.Text += "Za atakowano za " + (int)(weapon.damage * player.strenght_points) + "\n";
                            }

                            if(enemy.life<=0)
                            {
                                richTextBox1.Text += enemy.name+" nieżyje "+"\n";
                                button1.Enabled = true;
                                player.Xp += enemy.xp;
                            }
                            else
                            {
                                if(player.life - enemy.damage<=0)
                                {
                                    player.life = 0;
                                }
                                else
                                {
                                    richTextBox1.Text += enemy.name + " ma " + enemy.life + " życia i atakuje za " + enemy.damage + "\n";
                                    player.life -= enemy.damage;
                                }
                            }
                        }
                    }
                    else
                    {
                        richTextBox2.Text = "Nie mam w kogo bić\n";
                    }
                }
                else
                {
                    richTextBox2.Text = "Z tym nic nie zrobie\n";
                }
            }
            else
            {
                richTextBox2.Text = "Wybierz cos\n";
            }
        }

        private async void Form1_Paint(object sender, PaintEventArgs e)
        {
            Life_Update();
            Mana_Update();
            Xp_Update();
            Backpack_Update();
            await Task.Delay(50);
            if (player.life <= 0)
            {

                richTextBox2.Clear();
                richTextBox2.Text = "UMARŁEŚ!!!";
                progressBar1.Value = 0;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }//updating stats

        private void button3_Click(object sender, EventArgs e)//Desctiption for Main window
        {
            if (object_list[object_list.Count - 1].GetType().Name == "Enemy")
            {
                Enemy enemy = (Enemy)object_list.Last();
                richTextBox2.Text = enemy.Introduce();

            }
            else if (object_list[object_list.Count - 1].GetType().Name == "Item")
            {
                Item item = (Item)object_list.Last();
                richTextBox2.Text = item.Introduce();
            }
            else if (object_list[object_list.Count - 1].GetType().Name == "Mixture")
            {
                Mixture mixture = (Mixture)object_list.Last();
                richTextBox2.Text = mixture.Introduce();
            }
            else
            {
                Weapon weapon = (Weapon)object_list.Last();
                richTextBox2.Text = weapon.Introduce();
            }

        }

        private void button5_Click(object sender, EventArgs e)//Desctiption for backpack
        {

            if(comboBox1.SelectedIndex!=-1)
            {
                if (player.backpack[comboBox1.SelectedIndex].GetType().Name == "Item")
                {
                    Item item = (Item)player.backpack[comboBox1.SelectedIndex];
                    richTextBox2.Text = item.Introduce();
                }
                else if (player.backpack[comboBox1.SelectedIndex].GetType().Name == "Weapon")
                {
                    Weapon weapon = (Weapon)player.backpack[comboBox1.SelectedIndex];
                    richTextBox2.Text = weapon.Introduce();
                }
                else if (player.backpack[comboBox1.SelectedIndex].GetType().Name == "Mixture")
                {
                    Mixture mixture = (Mixture)player.backpack[comboBox1.SelectedIndex];
                    richTextBox2.Text = mixture.Introduce();
                }
            }
            else
            {
                richTextBox2.Text = $"Wybierz cos\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)//delete
        {
            player.backpack.RemoveAt(comboBox1.SelectedIndex);
            comboBox1.Items.Clear();
            foreach (Item item in player.backpack)
            {
                comboBox1.Items.Add(item.name);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for(int i=0;i<300;i++)
            {
                int r = rand.Next(1, 101);
                if (r==100)
                {
                    richTextBox1.Text += r + "\n";
                }
                
            }
        }//god button
    }
}
