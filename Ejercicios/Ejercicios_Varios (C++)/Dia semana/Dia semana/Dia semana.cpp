// Dia semana.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;


void main()
{
	locale::global(locale("spanish"));
	cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::AirSu Software:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-"<<endl;
	cout<<endl;
	short dsem;
	cout<<"Introduce el numero del dia de la semana: ";
	cin>>dsem;
	switch(dsem)
	{
	case 1:
		cout<<"Es Domingo";
		break;
	case 2:
		cout<<"Es Lunes";
		break;
	case 3:
		cout<<"Es Martes";
		break;
	case 4:
		cout<<"Es Miercoles";
		break;
	case 5:
		cout<<"Es Jueves";
		break;
	case 6:
		cout<<"Es Viernes";
		break;
	case 7:
		cout<<"Es Sabado";
		break;
	default:
		cout<<"Eztah uzteh loko'?";
	}
	_getch();
}