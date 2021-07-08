// Arreglos.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <cmath>
#include "string.h"
using namespace std;
#define fanta system("cls")
void main()
{
	int x;
	char nombre[7]="Darien";
	cout << nombre[0];
	cout << nombre[1];
	cout << nombre[2];
	cout << nombre[3];
	cout << nombre[4];
	cout << nombre[5]<<endl<<endl;
	_getch();
	fanta;
	//-----------------------
	cout << nombre[0]<<endl;
	cout << nombre[1]<<endl;
	cout << nombre[2]<<endl;
	cout << nombre[3]<<endl;
	cout << nombre[4]<<endl;
	cout << nombre[5]<<endl;
	cout << endl;
	_getch();
	fanta;
	//----------------------
	for (x=0;x<6;x++)
		cout<< nombre[x]<<'_';
	_getch();
	fanta;
	//----------------------
	cout << endl << endl;
	for(x=0; x < 7-1; x++);
		nombre[x]='@';
	cout << nombre;
	//----------------------
	short edad[7]={13, 14, 15, 16, 17, 17, 18};
	cout << edad[0] << endl
		 << edad[1] << endl
		 << edad[3] << endl
		 << edad[4] << endl
		 << edad[5] << endl
		 << edad[6] << endl
		 << edad[7] << endl;
	_getch();
}

