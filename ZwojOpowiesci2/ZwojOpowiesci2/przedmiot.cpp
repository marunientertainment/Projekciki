#include "przedmiot.h"
#include "obiekt.h"
#include <string>
#include <stdlib.h>
#include <time.h>
#include <sstream>

std::string int2str(int i)
{
    std::stringstream ss;
    std::string temp;
    ss << i;
    ss >> temp;
    return temp;
}

std::string float2str(float i)
{
    std::stringstream ss;
    std::string temp;
    ss << i;
    ss >> temp;
    return temp;
}
Przedmiot::Przedmiot(std::string Nazwa, std::string Opis, float Waga, int Cena, bool CzyMagiczny)
{
    srand (time(NULL));
    nazwa=Nazwa;
    opis=Opis;
    waga=Waga;
    cena=Cena;
    int p;
    if(rand()%2==0)
    {
        p=-1;
    }
    else
    {
        p=1;
    }
    float pf = (rand()%30 +1)/100;
    wartosc=cena+(p*pf*cena);

}
std::string Przedmiot::PrzedstawSie()
{
    return "Jest to "+nazwa+" Opis: "+opis+" waży "+float2str(waga)+". Może kosztować około "+int2str(wartosc)+" Monet";
}
