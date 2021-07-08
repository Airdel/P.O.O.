// Tarea numero primo.cpp: define el punto de entrada de la aplicación de consola.
//
#include "stdafx.h"
#include<stdlib.h>
#include<iostream>
#include<conio.h>
#include<time.h>

using namespace std;
void main()
{
	short num;
	cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-"<<endl;
	cout << "Introduce un numero: ";
	cin >> num;
	if (!(num % 2 == 0))
		cout << "Es primo c:";
	else
		cout << "No es primo :c";

_getch();
}

