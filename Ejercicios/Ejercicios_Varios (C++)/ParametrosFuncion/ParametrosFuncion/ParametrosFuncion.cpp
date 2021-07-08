// ParametrosFuncion.cpp: define el punto de entrada de la aplicación de consola.
//
#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <cmath>
#include "string.h"
using namespace std;

//:::------------------------------------------:::

double const sueldoHora = 45.0;
void leeDatosEmpleado(char nom[], short &hT)
	{
		cout << "Nombre del empleado: ";
		cin.getline(nom,100);
		cout << "Numero de horas trabajadas: ";
		cin >> hT;
	}
//:::------------------------------------------:::
double calculaSueldo(double hT)
{
	return(sueldoHora * hT);
}
//:::----------------------------------------- :::
void imprimeDatos(char nom[], short hT, short sueldoT)
{
	cout << "Hola " << nom << "." << endl;
	if(hT == 1)
	{
	cout << "Has trabajado durante: " << hT << " hora; Tu sueldo es de: " << sueldoT;
	}
	else
	{
		cout << "Has trabajado durante: " << hT << " horas; Tu sueldo es de: " << sueldoT;
	}
}
void main()
{
	locale::global(locale("spanish"));
	char nombre[100];
	short hrsTrabajadas;
	double sueldoTrabajador;
	//inicio
	cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-"<< endl << endl;

	cout << "programa de cálculo del sueldo del trabajador ¡ " << endl;

	leeDatosEmpleado(nombre, hrsTrabajadas);
	//cout << "Su sueldo es: " << calculaSueldo(hrsTrabajadas) << "." << endl;
	//cout << "Adeuu";
	sueldoTrabajador = calculaSueldo(hrsTrabajadas);
	system("cls");
	imprimeDatos(nombre, hrsTrabajadas, sueldoTrabajador);


	_getch();
}

