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
        private int lvl=1;
        public int strenght_points=0;
        public int mana_points=0;
        public int life_points=0;
        Backpack backpack = new Backpack(5f);
        public int Xp
        {
            get
            {
                return xp;
            }
            set
            {
                if (xp < lvl * 50)
                {
                    xp = value;
                }
                else
                {
                    xp = value;
                    xp = xp - lvl * 50;
                    lvl++;
                }
            }
        }
        public Player()
        {
            life = max_life;
            mana = max_mana;
        }
        public Player(int Max_Life, int Max_Mana, int Xp, int Lvl, int Strenght_points, int Mana_points, int Life_points)
        {
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
