// ciclos v5.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

void main()
{
	//Declaracion de variables
	float sueldodia;
	char nombre[100];
	short diastrabajo;
	//inicio
	locale::global(locale("spanish"));
	cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-"<<endl;
														
	cout<<endl;
	cout<<"Introduce tus dias de trabajo: ";
	cin>>diastrabajo;
	cin.ignore();
	cout<<"Introduce tu nombre: ";
	cin.getline(nombre, 100);
	cout<<"Hola, "<<nombre<<" introduce tu sueldo por dia: ";
	cin>>sueldodia;
	
	cout<<nombre<<" "<<sueldodia<<" "<<diastrabajo;
	_getch();
}

