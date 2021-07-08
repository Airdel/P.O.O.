#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <cmath>
#include <math.h>
#include "string.h"
using namespace std;
double suma(double x, double y)
{
	double t;
	t = x + y;
	return(t);
}
double resta(double x, double y)
{
	return(x - y);
}
double multiplicacion(double x, double y)
{
	return(x * y);
}
double division(double x, double y)
{
	return(x / y);
}
double modulo(int x, int y)
{
	return(x % y);
}
double seno(double x)
{
	return((sinf(x))*3.1416/180);
}
double coseno(double x)
{
	return((cosf(x))*3.1416/180);
}
double tangente(double x)
{
	return((tanf(x))*3.1416/180);
}
char menu()
{
	char re = 0;
	cout << endl << endl; 
	cout << "------------------------------" << endl;
	cout << "Calculadora simple para CMD" << endl;
	cout << "     -Menu de opciones-" << endl;
	cout << "1.- Sumar (+)" << endl
		 << "2.- Restar(-)" << endl
		 << "3.- Multiplicar (*)" << endl
		 << "4.- Dividir (/)" << endl
		 << "5.- Modulo (%)" << endl
		 << "6.- Seno (s)" << endl
		 << "7.- Coseno (c)" << endl
		 << "8.- Tangente (t)" << endl
	     << "9.- Salir (e)" << endl;
	cout << "Introdusca su opcion: ";
	cin >> re;
	return re;

}
void leeDatos(double &x, double &y)
{
	cout << "Introduzca el primer numero: ";
	cin >> x;
	cout << "Introduzca el segundo numero: ";
	cin >> y;

}
void leeDatoslog(double &x)
{
    cout << "Introduzca el numero: ";
    cin >> x;
}
