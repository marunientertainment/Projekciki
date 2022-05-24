using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Player
    {
        public int life;
        public int mana;
        public int xp;
        public int lvl;
        Backpack backpack = new Backpack(5f);
    }
}
