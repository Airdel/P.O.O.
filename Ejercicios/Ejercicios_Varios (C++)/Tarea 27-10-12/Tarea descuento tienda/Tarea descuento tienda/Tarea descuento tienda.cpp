// Tarea descuento tienda.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <stdlib.h>
using namespace std;


void main()
{
	locale::global(locale("spanish"));
	//Declaracion de Variables
	float monto, total, desc;
	//Inicio de programa
	cout << "-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-" << endl;
	cout << endl;
	cout << "Bienvenido, introduce el monto de la compra: ";
	cin >> monto;
	if (monto >= 0 && monto <= 499)
		cout << "No hay descuento, su total es: " << monto;
	else
		if (monto >= 500 && monto <= 1000)
		{
			desc = monto*.05;
			total = monto - desc;
			cout << "Descuento del 5%, su total es: " << total;
		}
		else
			if (monto > 1000 && monto <= 7000)
			{
				desc = monto*0.11;
				total = monto - desc;
				cout << "Descuento del 11%, su total es: " << total;
			}
			else
				if (monto > 7000 && monto <= 15000)
				{
					desc = monto*0.18;
					total = monto - desc;
					cout << "Descuento del 18%, su total es: " << total;
				}
				else
					if (monto > 15000)
					{
						desc = monto*0.25;
							total = monto - desc;
						cout << "descuento del 25%, su total es: " << total;
					}
	_getch();
}

