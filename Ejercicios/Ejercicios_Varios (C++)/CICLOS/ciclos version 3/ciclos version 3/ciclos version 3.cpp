// ciclos version 3.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <string.h>
using namespace std;

void main()
{
	char letra, nombre [100], clave [20];
	/*do
	{
	cout<<"Sexo de la persona (m/f): ";
	cin>>letra;
	
	}while(!( letra=='M' || letra=='F' || letra== 'm' || letra== 'f'));
	cout<<":D";*/
//-----------------------------------------------------------------------------------------
	/*do
	{
	cout<<"introduce un caracter (A-Z): ";
	cin>>letra;
	
	}while(!(letra>='A' && letra<='Z'));
	cout<<":D";
*/
//------------------------------------------------------------------------------------------
	/*cout<<"introduce el nombre: ";
	cin.getline(nombre,100);
	if(strcmp(nombre,"jorgue")==0)
		cout<<"konnichiwa, jorgue";
	else
		cout<<"No eres jorgue... :c";*/
//-----------------------------------------------------------------------------------------
	/*Contraseña*/
	do
	{
		cout<<"Introduce la clave de acceso: ";
		cin.getline(clave,20);
	}while(!(strcmp(clave, "Suair")==0));
	cout<<":D";
	_getch();
}

