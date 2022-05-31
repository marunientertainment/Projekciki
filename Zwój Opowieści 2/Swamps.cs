using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Swamps:Location
    {
        public Swamps(string Name, string Description, int Levels, bool Variant) : base(Name, Description, Levels, Variant)
        {
            name = Name;
            description = Description;
            name = Name;
            description = Description;
            variant = Variant;
            if (variant)
            {
                levels = (int)(1.5f * Levels);
            }
            else
            {
                levels = Levels;
            }
        }
        public new MyObject generate()
        {
            Item z = new Item("imie", "opis", 5, 5, true);//placeholder
            return z;
        }
    }
}
