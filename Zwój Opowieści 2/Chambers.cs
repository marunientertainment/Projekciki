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
            description = Description;
            variant = Variant;
            if (variant)
            {
                levels = (int)(1.5f * Levels);
            }
            else
            {
                levels = Levels;
            }
        }
        public new MyObject generate()
        {
            int p = rand.Next(1, 3);
            if (p == 2)//weapon or (enemy/mixture)
            {
                if (rand.Next(1, 7) == 1)
                {
                    Weapon stick = new Weapon("Kijek", "zwykły patyk", 0.1f, 1, 2, 0, false);
                    return stick;
                }
                else if (rand.Next(1, 7) == 2)
                {
                    Weapon big_stick = new Weapon("Kij", "Wiekszy patyk", 0.2f, 1, 3, 0, false);
                    return big_stick;
                }
                else if (rand.Next(1, 7) == 3)
                {
                    Weapon bone = new Weapon("Kość", "Biedny nieboszczyk, przynajmniej przyda sie po śmierci", 0.1f, 1, 5, 0, false);
                    return bone;
                }
                else if (rand.Next(1, 7) == 4)
                {
                    Weapon bat = new Weapon("Pałka", "Solidna", 0.4f, 3, 5, 0, false);
                    return bat;
                }
                else if (rand.Next(1, 7) == 5)
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
            else
            {
                if (rand.Next(1, 5) == 1)
                {
                    Enemy drowner = new Enemy("Utopiec", "Mam nadzieje że nie ma tu ich leża", 10, 2, 2);
                    return drowner;
                }
                else if (rand.Next(1, 5) == 2)
                {
                    Enemy Baba_Wodna = new Enemy("Baba Wodna", "Skąd to wylazło???", 20, 6, 10);
                    return Baba_Wodna;
                }
                else if (rand.Next(1, 5) == 4)
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
        }
    }
}
