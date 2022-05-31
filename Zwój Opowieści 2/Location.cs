using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Location: MyObject
    {
        public int levels;
        public bool variant;
        public bool finished;//for future
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
        public MyObject generate()
        {
            Enemy z = new Enemy("imie", "opis", 5, 5, 5);//just testing (to remove)
            return z;
        }
    }
}
