// Macros chan.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>

#define borrador system("cls") //Macro para limpiar la pantalla
#define cuadrado(x) x*x        //Macro para sacar el cuadrado de un numero
#define cubo(x) x*x*x		   //Macro para sacar el cubo de un numero
#define areaTriangulo(b,a) (b*a)/2
#define mayor2(x,y) (x > y)? (x) : (y)  
using namespace std;


void main()
{
	cout << "el cuadrado de 3 es: ";
	cout << cuadrado(3);
	_getch();
	borrador;
	cout << "el cubo de 3 es: ";
	cout << cubo(3);
	_getch();
	borrador;

	cout << "El Area del triangulo es: "
		 << areaTriangulo(5,8);
	_getch();
	borrador;

	cout << "El mayor de los numeros 3 y 6 es: "
		 << mayor2(3,6);
	_getch();
	

}

