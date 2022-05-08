#ifndef OPUSZCZONE_WIOSKI_H
#define OPUSZCZONE_WIOSKI_H
#include "lokalizacja.h"
#include "wrog.h"
class Opuszczone_Wioski:public Lokalizacja
{
public:
    Wrog GenerujWroga();
    Opuszczone_Wioski();
};

#endif // OPUSZCZONE_WIOSKI_H
