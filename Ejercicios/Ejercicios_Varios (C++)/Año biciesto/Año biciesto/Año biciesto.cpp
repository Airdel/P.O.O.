// Año biciesto.cpp: define el punto de entrada de la aplicación de consola.
//Determinar si un año es o no biciesto (un año es biciesto si es divisible entre 4 (2004, 2008, etc..)
//excepto si es divisible entre 100 (2100, 2200, ..), excepto si es divisible entre 400 (2000, 2400, ...)

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;


void main()
{
	locale::global(locale("spanish"));
	cout << "-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-" << endl;
	short year;
	cout << "Introduce el año:";
	cin >> year;
	//--------
	if (year % 400 == 0)
		cout <<"el año es biciesto";
	else
	{
	if (year % 100 == 0)
		cout << "El año no es biciesto";
	else
	{
		if (year % 4 == 0)
			cout<<"El año es biciesto";
		else
		{
			if(year % 4 != 0)
				cout<<"el año no es biciesto";
		}
	}
	}
	_getch();
}

