using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Location: MyObject
    {
        public int level;
        public Location(string Name, string Description, int Level)
        {
            name = Name;
            description = Description;
            level = Level;
        }
        public MyObject generate()
        {
            Enemy z = new Enemy("imie", "opis", 5, 5, 5);//just testing (to remove)
            return z;
        }
    }
}
