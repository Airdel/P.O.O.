#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include "string.h"
using namespace std;

void cadenas()
{
	char nombre[]="Airdel";
	cout << "Hola, soy " << nombre << endl
		 << "mi nombre tiene "
		 <<strlen(nombre)
		 <<"letras";
	_getch(); 
}                 

void imprimeMayusculas(char cad[])
{
	for( int x = 0 ; x < strlen(cad) ; x++)
	{
		cout <<(char)toupper(cad[x]); 
	}
}

 void imprimeMinusculas(char cad[])
 {
	 for( int x = 0 ; x < strlen(cad) ; x++)
	 {
		 cout <<(char)tolower(cad[x]);
	 }
 }
void comparaCadenas()
{
	char cadena[100];
	char cadena2[100];
	strcpy_s( cadena , "Juan Perez" );
	system("cls");
	cout << "Como te llamas?";
	cin.getline(cadena2, 100);
	if(strcmp(cadena, cadena2)==0)
		cout << "BIENVENIDO A LA ORDEN DE LOS JUAN PEREZ (Poland can't into space)";
	else
		cout << "Hola " << cadena2 << " Un placer conocerlo (Poland can into space....no, poland can't into space)";
}

































