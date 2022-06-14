using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public abstract class Location: MyObject
    {
        public int levels=0;
        public bool variant=false;
        public bool finished = false;//for future
        public int variant_mod;
        public Random rand = new Random();
        public Location(string Name, string Description, int Levels, bool Variant)
        {
            
            name = Name;
            description = Description;
            name = Name;
            variant = Variant;
            if (variant)
            {
                levels = (int)(1.5f * Levels);
                variant_mod = 10;
            }
            else
            {
                variant_mod = 0;
                levels = Levels;
            }

        }     
    }
}
