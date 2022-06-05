using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Player
    {
        public int max_life = 100;
        public int life;
        public int max_mana = 100;
        public int mana;
        private int xp=0;
        public int lvl=1;
        public float strenght_points=1;
        public float mana_points =1;
        public int life_points=0;
        public float maxcapacity=5;
        public List<Item> backpack = new List<Item>();
        public float capacity()
        {
            float weight = 0;
            foreach (Item n in backpack)
            {
                weight = n.weight;
            }
            return weight;
        }
        public bool add(Item item)
        {
            if (capacity() + item.weight <= maxcapacity)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void remove(int index)
        {
            backpack.RemoveAt(index);
        }
        public void clear()
        {
            backpack.Clear();
        }
        public int Xp
        {
            get
            {
                return xp;
            }
            set
            {
                if (value < lvl * 50)
                {
                    xp = value;
                }
                else if(value >= lvl * 50)
                {
                    xp = value;
                    xp = xp - lvl * 50;
                    lvl++;
                    LvlUp form = new LvlUp();
                    form.Show();
                }
                else if(value==0)
                {
                    xp = 0;
                }
            }
        }
        public Player()
        {
            life = max_life;
            mana = max_mana;
        }
        public Player(int Max_Life, int Max_Mana, int Xp, int Lvl, int Strenght_points, int Mana_points, int Life_points, float MaxCapacit)
        {
            maxcapacity = MaxCapacit;
            max_life = Max_Life;
            max_mana = Max_Mana;
            life = max_life;
            mana = max_mana;
            xp = Xp;
            lvl = Lvl;
            strenght_points = Strenght_points;
            mana_points = Mana_points;
            life_points = Life_points;
        }
        public Player(int Max_Life, int Max_Mana, int Strenght_points, int Mana_points, int Life_points)
        {
            max_life = Max_Life;
            max_mana = Max_Mana;
            life = max_life;
            mana = max_mana;
            strenght_points = Strenght_points;
            mana_points = Mana_points;
            life_points = Life_points;
        }
        public Player(int Max_Life, int Max_Mana)
        {
            max_life = Max_Life;
            max_mana = Max_Mana;
            life = max_life;
            mana = max_mana;
        }
    }
    
}
