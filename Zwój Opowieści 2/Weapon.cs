using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Weapon:Item
    {
        public int damage;
        public int consumption;
        public Weapon(string Name, string Description, float Weight, int Price,int Damage, int Consumption, bool Ismagic) : base(Name, Description, Weight, Price, Ismagic)
        {
            Random rand = new Random();
            damage= Damage;
            consumption = Consumption;
            name = Name;
            description = Description;
            weight = Weight;
            price = Price;
            ismagic = Ismagic;
            int p;
            if (rand.Next(1, 2) % 2 == 0)
            {
                p = -1;
            }
            else
            {
                p = 1;
            }
            float pf = (rand.Next(1, 30) + 1) / 100f;
            value = price + (int)(p * pf * price);
            if(!Ismagic)
            {
                consumption = 0;
            }
        }
        public new string Introduce()
        {
            if (ismagic)
            {
                return "Jest to " + name + " Opis: " + description + ", BIJE ZA "+damage+", zabiera "+consumption+" MANY, a waży " + weight + ". Może kosztować około " + price + " Monet";
            }
            else
            {
                return "Jest to " + name + " Opis: " + description + ", BIJE ZA " + damage + ", a waży " + weight + ". Może kosztować około " + price + " Monet";
            }
        }
    }
}
