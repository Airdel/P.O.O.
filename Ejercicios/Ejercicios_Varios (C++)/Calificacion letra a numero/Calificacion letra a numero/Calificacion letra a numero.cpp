// Calificacion letra a numero.cpp :Switch
//Developed by: Airdel
#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

void main()
{
	locale::global(locale("spanish"));
	cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::AirSu Software:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-"<<endl;
	char calLetra;
	short calNumero;
	cout<<"Bienvenido, introdusca la calificacion (N/I/S/E): ";
	cin>>calLetra;
	//Para cambiarla a mayuscula
	//calLetra= uppercase(calLetra);----------------------------------------------------------------------------------------------------------------------------Importante!
	//calLetra= lowercase(calLetra);----------------------------------------------------------------------------------------------------------------------------Importante!
	switch(calLetra)
	{
		case'N':
		case'n':
			calNumero=5;
			cout<<"La calificacion N es equivalente a: "
			<<calNumero;
			break;
		case'I':
		case'i':
			calNumero=7;
			cout<<"La calificacion I es equivalente a: "
				<<calNumero;
			break;
		case'S':
		case's':
			calNumero=9;
			cout<<"La calificacion S es equivalente a: "
				<<calNumero;
			break;
		case'E':
		case'e':
			calNumero=10;
			cout<<"la calificacion E es equivalente a: "
				<<calNumero;
			break;

		default:cout<<"Esa calificacion no existe.";
	}

			
	_getch();
}