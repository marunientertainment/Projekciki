#ifndef LOKALIZACJA_H
#define LOKALIZACJA_H
#include "obiekt.h"

class Lokalizacja:public Obiekt
{
    int poziom;
public:  
    void SetPoziom(int trudnosc);
    Lokalizacja(int Poziom);
    Lokalizacja();
};

#endif // LOKALIZACJA_H
