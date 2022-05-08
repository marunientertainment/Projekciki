#include "wrog.h"
#include <stdexcept>
#include <iostream>
Wrog::Wrog(int Zycie, int Obrazenia)
{
    obrazenia=Obrazenia;
}

int Wrog::SetZycie(int n)
{
    if(n<=0)
    {
        return 20;
    }
    return n;
}
