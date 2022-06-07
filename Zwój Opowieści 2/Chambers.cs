using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Chambers:Location
    {
        public Chambers(string Name, string Description, int Levels, bool Variant) : base(Name, Description, Levels, Variant)
        {
            name = Name;
            description = Description;
            name = Name;
            variant = Variant;
            if (variant)
            {
                levels = (int)(1.5f * Levels);
                variant_mod = 10;
            }
            else
            {
                variant_mod = 0;
                levels = Levels;
            }
        }
        public MyObject generate(int step_mode)
        {
            if (1 <= rand.Next(1, 101) && rand.Next(1, 101) < (60 - variant_mod - (step_mode / 10)))
            {
                if (1 <= rand.Next(1, 101) && rand.Next(1, 101) < (40 - variant_mod - (step_mode / 10)))
                {
                    if (rand.Next(1, 3) == 1)
                    {
                        Mixture mixture = new Mixture("Mikstura", "Leczy zdrowie", 0.1f, 10, 10, false);
                        return mixture;
                    }
                    else
                    {
                        Mixture mixture = new Mixture("Mikstura", "odnawia mane", 0.1f, 10, 10, true);
                        return mixture;
                    }
                }
                else
                {
                    if (rand.Next(1, 6) == 1)
                    {
                        Weapon stick = new Weapon("Kijek", "zwykły patyk", 0.1f, 1, 2, 0, false);
                        return stick;
                    }
                    else if (rand.Next(1, 6) == 2)
                    {
                        Weapon big_stick = new Weapon("Kij", "Wiekszy patyk", 0.2f, 1, 3, 0, false);
                        return big_stick;
                    }
                    else if (rand.Next(1, 6) == 3)
                    {
                        Weapon bone = new Weapon("Kość", "Biedny nieboszczyk, przynajmniej przyda sie po śmierci", 0.1f, 1, 5, 0, false);
                        return bone;
                    }
                    else if (rand.Next(1, 6) == 4)
                    {
                        Weapon bat = new Weapon("Pałke", "Solidna", 0.4f, 3, 5, 0, false);
                        return bat;
                    }
                    else if (rand.Next(1, 6) == 5)
                    {
                        if (variant)
                        {
                            Weapon pitchfork = new Weapon("Widły", "Jedno pchnięcie, 4 rany kłuta", 0.2f, 5, 5, 0, false);
                            return pitchfork;
                        }
                        else
                        {
                            Weapon poroze = new Weapon("Poroże Jelenia", "Duże", 0.2f, 5, 5, 0, false);
                            return poroze;
                        }

                    }
                }

            }
            else
            {
                if (rand.Next(1, 5) == 1)
                {
                    Enemy drowner = new Enemy("Utopiec", "Mam nadzieje że nie ma tu ich leża", 10, 2, 2);
                    return drowner;
                }
                else
                {
                    Enemy Baba_Wodna = new Enemy("Baba Wodna", "Skąd to wylazło???", 20, 6, 30);
                    return Baba_Wodna;
                }
            }
            Item item = new Item("Miotła", "Awaryjna miotła, trzeba pozamiatać", 0, 0, true);
            return item;
        }
    }
}
