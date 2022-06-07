using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Selector
    {
        public Swamps S1 = new Swamps("Bagna1", "Bagna1", 10, false);
        public Swamps S2 = new Swamps("Bagna2", "Bagna2", 10, true);
        public Left_Vilages LV1 = new Left_Vilages("Opiszczona wioska 1", "Opiszczona wioska 1", 10, false);
        public Left_Vilages LV2 = new Left_Vilages("Opiszczona wioska 2", "Opiszczona wioska 2", 10, true);
        public Chambers C1 = new Chambers("Komnaty 1", "Komnaty 1", 10, false);
        public Chambers C2 = new Chambers("Komnaty 2", "Komnaty 2", 10, true);
        public Black_Castle B1 = new Black_Castle("Czarny Zamek 1", "Czarny Zamek 1", 10, false);
        public Black_Castle B2 = new Black_Castle("Czarny Zamek 2", "Czarny Zamek 2", 10, true);

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
                return S2.name;
            }
            else if (current_location == 2)
            {
                return LV1.name;
            }
            else if (current_location == 3)
            {
                return LV2.name;
            }
            else if (current_location == 4)
            {
                return C1.name;
            }
            else if (current_location == 5)
            {
                return C2.name;
            }
            else if (current_location == 6)
            {
                return B1.name;
            }
            else if (current_location == 7)
            {
                return B2.name;
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
                return S2.description;
            }
            else if (current_location == 2)
            {
                return LV1.description;
            }
            else if (current_location == 3)
            {
                return LV2.description;
            }
            else if (current_location == 4)
            {
                return C1.description;
            }
            else if (current_location == 5)
            {
                return C2.description;
            }
            else if (current_location == 6)
            {
                return B1.description;
            }
            else if (current_location == 7)
            {
                return B2.description;
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
                return S2.levels;
            }
            else if (current_location == 2)
            {
                return LV1.levels;
            }
            else if (current_location == 3)
            {
                return LV2.levels;
            }
            else if (current_location == 4)
            {
                return C1.levels;
            }
            else if (current_location == 5)
            {
                return C2.levels;
            }
            else if (current_location == 6)
            {
                return B1.levels;
            }
            else if (current_location == 7)
            {
                return B2.levels;
            }
            return S1.levels;
        }
        //work in progress
        /*public bool Variant(int current_location)
        {
            
        }*/
        public bool Finished(int current_location)
        {
            if (current_location == 0)
            {
                return S1.finished;
            }
            else if (current_location == 1)
            {
                return S2.finished;
            }
            else if (current_location == 2)
            {
                return LV1.finished;
            }
            else if (current_location == 3)
            {
                return LV2.finished;
            }
            else if (current_location == 4)
            {
                return C1.finished;
            }
            else if (current_location == 5)
            {
                return C2.finished;
            }
            else if (current_location == 6)
            {
                return B1.finished;
            }
            else if (current_location == 7)
            {
                return B2.finished;
            }
            return S1.finished;
        }
        public MyObject Generate(int current_location,int step)
        {
            if (current_location == 0)
            {
                return S1.generate(step);
            }
            else if (current_location == 1)
            {
                return S2.generate(step);
            }
            else if (current_location == 2)
            {
                return LV1.generate(step);
            }
            else if (current_location == 3)
            {
                return LV2.generate(step);
            }
            else if (current_location == 4)
            {
                return C1.generate(step);
            }
            else if (current_location == 5)
            {
                return C2.generate(step);
            }
            else if (current_location == 6)
            {
                return B1.generate(step);
            }
            else if (current_location == 7)
            {
                return B2.generate(step);
            }
            return S1.generate(1);
        }
    }
}
