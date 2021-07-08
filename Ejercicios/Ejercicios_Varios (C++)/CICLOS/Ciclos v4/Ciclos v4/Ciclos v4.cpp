// Ciclos v4.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

void main()
{
	cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-"<<endl;
	//Sentencia for
		//for(int x=100 ; x>=20 ;x=x-1 ) 
		//cout<<"Darien Rafael Marquez Vazquez -Airdel-\n";
	//-------------------------------------------------------------------------------------------------------------------------------------------
		//float num, suma = 0;
		//int y;
		//for( y = 1 ; y <= 10 ; y++){
		//	cout<<y<<".-"<<"Introduce un numero: ";
		//	cin>>num;
		//	suma = suma+num;
		//}
		//cout<<endl<<"-----------------------------------------------------------"<<endl;
		//cout<<"La suma de todos los numeros leidos es: "<<suma;
	//-------------------------------------------------------------------------------------------------------------------------------------------
	//	for (int x = 1 ; x <=10 ; x++)
	//		cout << "1 * "<<x<<" = "<<x<< endl ;
		/*for (int x = 2 ; x<=20 ; x=x+2)
			cout << "2 * "<<x<<" = " <<x <<endl;*/
	int x, y, z, mul = 1;
	
	cout << "Introduce la tabla deseada: ";
	
	cin >> x;
	z = x;
	for (y = 1; y <= 10; y = y++)
	{
		x = z * y;
		cout << z << " * " << mul << " = " << x << endl;
		mul++;

	}
		
	


	_getch();
}
