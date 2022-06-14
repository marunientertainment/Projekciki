using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Item: MyObject
    {
        public float weight;
        public int price;
        public int value;
        public bool ismagic;
        public Item(string Name, string Description, float Weight, int Price, bool Ismagic)
        {
            Random rand = new Random();
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
            value = price + (int)Math.Ceiling(p * pf * price);
        }
        public string Introduce()
        {
            if (ismagic)
            {
                return "Jest to " + name + " Opis: " + description + ", jest to przedmiot magiczny a waży " + weight + ". Może kosztować około " + price + " Monet";
            }
            else
            {
                return "Jest to " + name + " Opis: " + description + " waży " + weight + ". Może kosztować około " + price + " Monet";
            }
        }        
    }
}
