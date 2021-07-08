#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include "math.h"
//----------------
#define pi 3.1416

using namespace std;
//---------------------..
void areaCirculo()
{
	double radio, area;
	cout << "Area Circulo" << endl
		 << "Cual es el valor del radio: ";
	cin >> radio;
	area= pi * pow(radio, 2);
	cout << "El area del circulo es: " << area << endl;
	_getch();
}
//---------------------..
void areaTriangulo()
{
	double base, altura, area;
	cout << "Area Triangulo" << endl
		 << "Cual es el valor de la base: ";
	cin >> base;
	cout << "Cual es el valor de la altura: ";
	cin >> altura;
	area = (base*altura)/2;
	cout << "el area del triangulo es: " << area << endl;
	_getch();
}
//---------------------..
void areaCuadrado()
{
	double lado, area;
	cout << "Area Cuadrado--" << endl
		 << "Cual es el valor de la base: ";
	cin >> lado;
	area = pow(lado, 2);
	cout << "el area del Cuadrado es: " << area << endl;
	_getch();
}
//---------------------..
void areaRectangulo()
{
	double base, altura, area;
	cout << "Area Rectangulo" << endl
		 << "Cual es el valor de la base: ";
	cin >> base;
	cout << "Cual es el valor de la altura: ";
	cin >> altura;
	area = base*altura;
	cout << "el area del Rectangulo es: " << area << endl;
	_getch();
}
//---------------------..
void pitagoras()
{
	double a, b, c;
	cout << "Teorema de Pitagoras" << endl
	     << "Introduce el cateto a";
		 cin >> a;
	cout << "Introduce el cateto b";
		 cin >> b;
	c = pow(a,2) + pow(b,2);
	cout << "La medida de la hipotenusa es: " << c << " u.";
}	
//---------------------..
void navidad()
{
	system("Color 24");
	cout << "--------------------------------"<<endl;
	cout << "    :D!                  ** *  "<<endl;
	cout << "                         * *   "<<endl;
	cout << "                        **     "<<endl;
	cout << "                       |*|    "<<endl;
	cout << "    ___________________|_|    "<<endl;
	cout << "   /|                    |     "<<endl;
	cout << "  / | -_-:::Airdel:::-_- |     "<<endl;    
	cout << " /  |   _           _    |    "<<endl;
	cout << "/   |  |_|  ____   |_|   |    "<<endl;
	cout << "    |       |  |         |      "<<endl;
	cout << "--------------------------------"<<endl;
	cout << "Merry Christmas and happy new year!";
	_getch();
	system("color 0");
	system("cls");
	
}
//---------------------..


