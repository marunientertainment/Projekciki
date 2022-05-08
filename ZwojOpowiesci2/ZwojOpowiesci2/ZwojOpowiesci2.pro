QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

CONFIG += c++17

# You can make your code fail to compile if it uses deprecated APIs.
# In order to do so, uncomment the following line.
#DEFINES += QT_DISABLE_DEPRECATED_BEFORE=0x060000    # disables all the APIs deprecated before Qt 6.0.0

SOURCES += \
    bagna.cpp \
    bron.cpp \
    czarny_zamek.cpp \
    generator.cpp \
    komnaty.cpp \
    lokalizacja.cpp \
    main.cpp \
    mainwindow.cpp \
    mikstura.cpp \
    nawiedzone_wlosci.cpp \
    obiekt.cpp \
    opuszczone_wioski.cpp \
    przedmiot.cpp \
    wrog.cpp

HEADERS += \
    bagna.h \
    bron.h \
    czarny_zamek.h \
    generator.h \
    komnaty.h \
    lokalizacja.h \
    mainwindow.h \
    mikstura.h \
    nawiedzone_wlosci.h \
    obiekt.h \
    opuszczone_wioski.h \
    przedmiot.h \
    wrog.h

FORMS += \
    mainwindow.ui

# Default rules for deployment.
qnx: target.path = /tmp/$${TARGET}/bin
else: unix:!android: target.path = /opt/$${TARGET}/bin
!isEmpty(target.path): INSTALLS += target
