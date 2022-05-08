#include "mainwindow.h"
#include <string>
#include <QApplication>
#include "wrog.h"
int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;
    Wrog maszkara(0,5);
    w.show();
    return a.exec();
}
