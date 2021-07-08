// Calculadora.cpp: calculadora con funciones basicas.
//Developed by: Airdel

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <cmath>
#include "string.h"
#include "calculadora.h"
using namespace std;
int o, num1, num2;
void main()
{
	//Declaracion
	//inicio
	cout << "-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-" << endl;
	cout << endl;
	cout << "Calculadora para cmd con funciones basicas";
	cout << "Por favor, seleccione la operacion a realizar";
	cout << "1.-Suma" << endl << "2.-Resta" << endl << "3.-Multiplicacion" << endl << "4.-Division"
		<< endl << "5.-Seno" << endl << "6.-Coseno" << endl << "7.-Tangente";
	cout << endl << "Introdusca su opcion: ";
	cin >> o;
	switch (o)
	{
		case 1:{suma();}
		case 2:
		{
			cout << endl << "Introdusca los numeros para la operacion." << endl;
			cout << "Primer numero: ";
			cin >> num1;
			cout << "Segundo numero: ";
			cin >> num2;
			cout << "El resultado de la resta es: ";
			resta(num1, num2);
		}
		case 3:
		{
			cout << endl << "Introdusca los numeros para la operacion." << endl;
			cout << "Primer numero: ";
			cin >> num1;
			cout << "Segundo numero: ";
			cin >> num2;
			cout << "El resultado de la suma es: ";
			multiplicacion(num1, num2);
		}
		case 4:
		{
			cout << endl << "Introdusca los numeros para la operacion." << endl;
			cout << "Primer numero: ";
			cin >> num1;
			cout << "Segundo numero: ";
			cin >> num2;
			cout << "El resultado de la division es: ";
			division(num1, num2);
		}
		case 5:
		{
			cout << endl << "Introdusca el numero: ";
			cin >> num1;
			cout << "La raiz cuadrada de " << num1 << " Es: ";
			Raiz(num1);
		}
		case 6:
		{
			cout << endl << "Introdusca el numero: ";
			cin >> num1;
			cout << "El seno de " << num1 << " es: ";
			seno(num1);
		}
		case 7:
		{
			cout << endl << "Introdusca el numero: ";
			cin >> num1;
			cout << "El coseno de " << num1 << " es: ";
			coseno(num1);
		}
		case 8:
		{
			cout << endl << "Introdusca el numero: ";
			cin >> num1;
			cout << "El tangente de " << num1 << " es: ";
			tangente(num1);
		}

	}
	_getch();
}

