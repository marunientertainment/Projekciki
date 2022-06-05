using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    class Selector
    {
        public Swamps S1 = new Swamps("S1", "opis", 10, false);
        public Swamps S2 = new Swamps("S2", "opis", 2, true);
        public Left_Vilages LV1 = new Left_Vilages("LV1", "opis", 10, false);
        public Left_Vilages LV2 = new Left_Vilages("LV2", "opis", 2, true);
        public Chambers C1 = new Chambers("C1", "opis", 10, false);
        public Chambers C2 = new Chambers("C2", "opis", 2, true);
        public Black_Castle B1 = new Black_Castle("B1", "opis", 10, false);
        public Black_Castle B2 = new Black_Castle("B2", "opis", 2, true);
        public Selector()
        {

        }
        public string Name(int current_location)
        {
            if (current_location == 0)
            {
                return S1.name;
            }
            else if (current_location == 1)
            {
                return LV1.name;
            }
            else if (current_location == 2)
            {
                return C1.name;
            }
            else if (current_location == 3)
            {
                return B1.name;
            }
            return S1.name;
        }
        public string Description(int current_location)
        {
            if (current_location == 0)
            {
                return S1.description;
            }
            else if (current_location == 1)
            {
                return LV1.description;
            }
            else if (current_location == 2)
            {
                return C1.description;
            }
            else if (current_location == 3)
            {
                return B1.description;
            }
            return S1.description;
        }
        public int Levels(int current_location)
        {
            if (current_location == 0)
            {
                return S1.levels;
            }
            else if (current_location == 1)
            {
                return LV1.levels;
            }
            else if (current_location == 2)
            {
                return C1.levels;
            }
            else if (current_location == 3)
            {
                return B1.levels;
            }
            return S1.levels;
        }
        //work in progress
        /*public bool Variant(int current_location)
        {
            
        }
        public bool Finished(int current_location)
        {

        }*/
        public MyObject Generate(int current_location)
        {
            if (current_location == 0)
            {
                return S1.generate();
            }
            else if (current_location == 1)
            {
                return LV1.generate();
            }
            else if (current_location == 2)
            {
                return C1.generate();
            }
            else if (current_location == 3)
            {
                return B1.generate();
            }
            return S1.generate();
        }
    }
}
