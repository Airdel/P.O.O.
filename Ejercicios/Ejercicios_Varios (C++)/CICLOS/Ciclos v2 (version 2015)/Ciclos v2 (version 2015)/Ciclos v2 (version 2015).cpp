// Ciclos v2.cpp
//Developed by: Airdel

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

void main()
{
	locale::global(locale("spanish"));
	short num;
	//inicio de programa----------------------------------------------------------------------------------------------------------------PROGRAMA SIN TERMINAR-------------------------------------------------------------------------------------------------------
	cout << "-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-" << endl;
	cout << endl;
	/*do
	{
	cout<<"introduce un numero (menor a 500): ";
	cin>>num;
	}while(num >= 500); */
	short num_magico;
	short magia;
	do
	{
		do
		{
			cout << "Adivinanza" << endl
				<< "introduce un numero entre 1 y 100: ";
			cin >> num_magico;

		} while (!(num_magico >= 1 && num_magico <= 100));
		//  (num_magico<1 || num_magico>100)
		if (num_magico == 52)
		{
			cout << "Yeah, adivinaste. Te ganaste una estrellita";
			magia = 4;
		}
		else
		{
			cout << "Sigue participando" << endl;
			magia = 0;
			while (magia >= 0)
			{
				magia = magia + 1;
				cout << "Sigue participando, te quedan: " << magia << " intentos.";
				switch (magia)
				{
				case 1:
					cout << "sigue participando, te quedan 2 intentos.";
				case 2:
					cout << "sigue participando, te queda 1 intento.";
				case 3:
					cout << "huy, perdiste:";
					break;
				}
			}
		}
	} while (magia == 4);
	_getch();
}