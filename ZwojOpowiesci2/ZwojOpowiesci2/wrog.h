#ifndef WROG_H
#define WROG_H
#include "obiekt.h"

class Wrog:public Obiekt
{
    int zycie;
public:
    int SetZycie(int n);
    int obrazenia;
    Wrog(int Zycie, int Obrazenia);
};

#endif // WROG_H
