// Ejercicio c++1.cpp: sueldo trabajador.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;
void main()
{
	locale::global(locale("spanish"));
	short sueldo, aumento, sueldot; 
	char nombre[100];
	cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::AirSu Software:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-"<<endl;
	cout<<endl;
	cout<<"Bienvenido trabajador"<<endl<<"Introduzca su nombre: ";
	cin.getline(nombre, 100);
	cout<<"Ahora introduzca su sueldo  (Solo numeros): ";
	cin>>sueldo;
	if (sueldo<=1000)
	{
		aumento=sueldo*0.15;
		sueldot=sueldo+aumento;
		cout<<"Hola "<<nombre<<endl<<" usted aplica a un aumento del 15% su nuevo sueldo es de: "<<sueldot;
	}
	else
	{
		aumento=sueldo*0.12;
		sueldot=sueldo+aumento;
		cout<<"Hola "<<nombre<<endl<<" usted aplica a un aumento del 12% su nuevo sueldo es de: "<<sueldot;
	}
	_getch();
}

