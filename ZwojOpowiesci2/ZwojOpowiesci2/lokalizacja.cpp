#include "lokalizacja.h"

void Lokalizacja::SetPoziom(int trudnosc)
{
    if(trudnosc>0&&trudnosc<3)
    {
        poziom=trudnosc;
    }
}

Lokalizacja::Lokalizacja(int Poziom)
{
    SetPoziom(Poziom);
}
Lokalizacja::Lokalizacja()
{
}
