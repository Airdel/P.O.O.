// Funciones prediseñadas kun.cpp: define el punto de entrada de la aplicación de consola.
//


#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include "math.h"
#include "milibreria.h"
#include "FuncionesCadena.h"
#include "funcionesPropias.h"

#define fanta system("cls")
#define pi 3.1416
using namespace std;

void main()
{
	double n1, n2;
	cout << "Introduce el primer valor: ";
	cin >> n1;
	cout << "Introduce el segundo valor: ";
	cin >> n2;
	cout << "El mayor de los dos es: ";
	cout << mayor2numeros(n1, n2);
	_getch();
	fanta;
	cin.ignore();
	comparaCadenas();
	_getch();
	fanta;
	imprimeMayusculas("darien");
	_getch();
	fanta;
	cadenas();
	_getch();
	navidad();
	_getch();
	fanta;
	double x = 5, y = 2;
	cout << "5 elevado al cuadrado es: " << pow(x, y) << endl;
	cout << "La raiz cuadrada de 9 es: " << sqrt(9.0);
	_getch();
	fanta;

	//-----
	areaCirculo();
	areaTriangulo();
	areaCuadrado();
	areaRectangulo();
	_getch();

}