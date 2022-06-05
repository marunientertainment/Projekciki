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
        public Random rand = new Random();
        public Location(string Name, string Description, int Levels, bool Variant)
        {
            name = Name;
            description = Description;
            variant = Variant;
            if(variant)
            {
                levels = (int)(1.5f * Levels);
            }
            else
            {
                levels = Levels;
            }

        }
        public Location()
        {

        }
        public MyObject generate()
        {
            Enemy z = new Enemy("tu jestem", "opis", 5, 5, 5);//just testing (to remove)
            return z;
        }
    }
}
