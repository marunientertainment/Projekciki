using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwój_Opowieści_2
{
    public class Left_Vilages:Location
    {
        public Left_Vilages(string Name, string Description, int Levels , bool Variant):base(Name, Description, Levels, Variant)
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
            int r = rand.Next(1, 101);
            int r2 = rand.Next(1, 101);
            int r3 = rand.Next(1, 6);
            int itemorenemy = (60 - variant_mod - (step_mode / 10));
            if (1 <= r && r < itemorenemy)
            {
                int weaponormixture = (40 - variant_mod - (step_mode / 10));
                if (1 <= r2 && r2 < weaponormixture)
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
                    if (r3 == 1)
                    {
                        Weapon stick = new Weapon("Kijek", "zwykły patyk", 0.1f, 1, 2, 0, false);
                        return stick;
                    }
                    else if (r3 == 2)
                    {
                        Weapon big_stick = new Weapon("Kij", "Wiekszy patyk", 0.2f, 1, 3, 0, false);
                        return big_stick;
                    }
                    else if (r3 == 3)
                    {
                        Weapon bone = new Weapon("Kość", "Biedny nieboszczyk, przynajmniej przyda sie po śmierci", 0.1f, 1, 5, 0, false);
                        return bone;
                    }
                    else if (r3 == 4)
                    {
                        Weapon bat = new Weapon("Pałke", "Solidna", 0.4f, 3, 5, 0, false);
                        return bat;
                    }
                    else if (r3 == 5)
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
                if (rand.Next(1, 3) == 1)
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
            Item item = new Item("Miotła", "Miotła awaryjna jeśli widzisz to znaczy ze gdzien wystąpił błąd", 0, 0, true);
            return item;
        }
    }
}
