using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Enemy:MyObject
    {
        public int life;
        public int xp;
        public int damage;
        public Enemy(string Name, string Description, int Life, int Damage, int Xp)
        {
            name = Name;
            description = Description;
            life = Life;
            damage = Damage;
            xp = Xp;
        }
        public string Indroduce()
        {
            return "Jest to " + name + " " + description + "(ma " + life + "punkow życia i bije za" + damage + ")";
        }
        
    }
}
