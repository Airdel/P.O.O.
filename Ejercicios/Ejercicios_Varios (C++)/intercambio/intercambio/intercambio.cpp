// intercambio.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

void main()
{
	char a,b,c;
	cout<<"_-_-_-_-_-_-_-_-_-_-_-:::AirSu Software:::_-_-_-_-_-_-_-_-_-_-_-"<<endl;
	cout<<endl;
	cout<<"Introduce el primer valor: ";
	cin>>a;
	cout<<"introduce el segundo valor: ";
	cin>>b;
	cout<<"Primera impresion de valores"<<endl;
	cout<<a<<endl<<b<<endl;
	c=a;
	a=b;
	b=c;
	cout<<"intercambio de valores, impresion 2."<<endl;
	cout<<a<<endl<<b;
	_getch();

}

