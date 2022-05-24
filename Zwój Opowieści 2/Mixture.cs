using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Mixture: Item
    {
        public int howmuch;
        public Mixture(string Name, string Description, float Weight, int Price, int Howmuch, bool Ismagic): base(Name, Description, Weight, Price, Ismagic)
        {
            Random rand = new Random();
            name = Name;
            description = Description;
            weight = Weight;
            price = Price;
            ismagic = Ismagic;
            howmuch = Howmuch;
            int p;
            if (rand.Next(1, 2) == 1)
            {
                p = -1;
            }
            else
            {
                p = 1;
            }
            float pf = rand.Next(1, 30)/100f;
            value = price + (int)(p * pf * price);
        }
        public new string  Introduce()
        {
            if (ismagic)
            {
                return "Jest to " + name + " Opis: " + description + ", ZWRACA: "+howmuch+" MANY a waży " + weight + ". Może kosztować około " + price + " Monet";
            }
            else
            {
                return "Jest to " + name + " Opis: " + description + ", ZWRACA: " + howmuch + " ŻYCIA a waży " + weight + ". Może kosztować około " + price + " Monet";
            }
        }
    }
}
