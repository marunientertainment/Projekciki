using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Swamps:Location
    {
        public Swamps(string Name, string Description, int Level) : base(Name, Description, Level)
        {
            name = Name;
            description = Description;
            level = Level;
        }
        public new MyObject generate()
        {
            Item z = new Item("imie", "opis", 5, 5, true);//placeholder
            return z;
        }
    }
}
