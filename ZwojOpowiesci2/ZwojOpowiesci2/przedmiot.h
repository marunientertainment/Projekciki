#ifndef PRZEDMIOT_H
#define PRZEDMIOT_H
#include "obiekt.h"
#include <string>
#include <time.h>
class Przedmiot :public Obiekt
{
    float waga;
    int cena;
    int wartosc;
public:

    std::string PrzedstawSie();
    Przedmiot(std::string Nazwa, std::string Opis, float Waga, int Cena);
};

#endif // PRZEDMIOT_H
