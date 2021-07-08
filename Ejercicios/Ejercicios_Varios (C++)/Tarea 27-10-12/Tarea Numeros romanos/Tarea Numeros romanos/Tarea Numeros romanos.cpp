// Tarea Numeros romanos.cpp: define el punto de entrada de la aplicación de consola.
//Developed by: Airdel

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <stdlib.h>
using namespace std;

void main()
{
	locale::global(locale("spanish"));
	//Declaracion de Variables
	short arabigo, c, d;
	//inicio de programa
	cout << "-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-" << endl;
	cout <<                 "Programa conversor de numeros arabigo/romanos"<<endl;
	do
	{
		cout << "Bienvenido, introdusca su numero: ";
		cin >> arabigo;
	} while (!(arabigo >= 1 && arabigo <= 100));
	c = arabigo / 10;
	d = arabigo % 10;
	cout << c;
	cout << d << ": ";
	if (arabigo >= 10 && arabigo <= 100 || c >= 1 && c <= 9)
	{
		if (c == 1)
			cout << "X";
		if (c == 2)
			cout << "XX";
		if (c == 3)
			cout << "XXX" ;
		if (c == 4)
			cout << "XL" ;
		if (c == 5)
			cout << "L";
		if (c == 6)
			cout << "LX" ;
		if (c == 7)
			cout << "LXX";
		if (c == 8)
			cout << "LXXX" ;
		if (c == 9)
			cout << "XC";
	}
	if (arabigo >= 1 && arabigo <= 9 || d >= 1 && d <= 9)
	{
		if (d == 1)
			cout << "I" ;
		if (d == 2)
			cout << "II" ;
		if (d == 3)
			cout << "III" ;
		if (d == 4)
			cout << "IV" ;
		if (d == 5)
			cout << "V";
		if (d == 6)
			cout << "VI";
		if (d == 7)
			cout << "VII";
		if (d == 8)
			cout << "VIII";
		if (d == 9)
			cout << "IX";
	}
	_getch();
}


	






	