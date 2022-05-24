using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    internal class Backpack
    {
        public float maxcapacity;
        List<Item> items=new List<Item>();
        public Backpack(float MaxCapacit)
        {
            maxcapacity = MaxCapacit;
        }
        public float capacity()
        {
            float weight=0;
            foreach (Item n in items)
            {
                weight = n.weight;
            }
            return weight;
        }       
        public bool add(Item item)
        {
            if(capacity()+item.weight<=maxcapacity)
            {
                items.Add(item);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void remove(int index)
        {
            items.RemoveAt(index);
        }
        public void clear()
        {
            items.Clear();
        }
    }
}
