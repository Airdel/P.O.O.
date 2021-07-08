// Ciclos.cpp: Clase guiada sobre la funcion While
//Developed by: Airdel

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

void main()
{
	////codigo de impresion nombre 10 veces
	//locale::global(locale("spanish"));
	////declaracion de variables
	//char nombre[100]="darien";
	//short c=1;
	////inicio de programa
	cout << "-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::AirSu software:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-" << endl;
	//cout << endl;
	//cout<<"introduce el valor de c: ";
	//cin>>c;
	//while(c<10)
	//{
	//	cout << nombre<<"-"<<endl;
	//	c=c+1;
	//}
	//_getch();
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//Codigo para imprimir los numeros del 0 al 20 (pares)
	/*short conta=0;
	while(conta<=20)
	{
		cout<<conta<<endl;
		conta=conta+2;
	}
	_getch();*/
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//Codigo para imprimir ASCII
	short conta=0;
	while(conta<=255)
	{
		cout<<"Letra: "<<(char)conta<<" Codigo: "<<conta<<endl;
		conta=conta+1;
	}
	_getch();
}