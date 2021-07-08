#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <cmath>
#include "string.h"
#include "calculadora.h"
using namespace std;

void main()
{
	char resp, e;
	double n1 = 0, n2 = 0, r;
	cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-"<<endl;
	do{
		resp = menu();
		switch(resp){
		case '1':
		case '+':
			leeDatos(n1, n2);
			r = suma(n1,n2);
			cout << "La suma es: " << r;
			_getch();
		break;

		case '2':
		case '-':
			leeDatos(n1,n2);
			r = resta(n1,n2);
			cout << "La resta es: " << r;
			_getch();
		break;
		case '3':
		case '*':
			leeDatos(n1,n2);
			r = multiplicacion(n1,n2);
			cout << "La multiplicacion de " <<n1 << " por " << n2 << ". Es: " << r;
			_getch();
		break;
		case '4':
		case '/':
			leeDatos(n1,n2);
			r = division(n1,n2);
			cout << "La division de " <<n1 << " entre " << n2 << ". Es: " << r;
			_getch();
		break;
		case '5':
		case '%':
			leeDatos(n1,n2);
			r = division(n1,n2);
			cout << "El modulo es: " << r;
			_getch();
		break;
		case '6':
		case 's':
			leeDatoslog(n1);
			r = seno(n1);
			cout << "El seno es: " << r;
			_getch();
		break;
		case '7':
		case 'c':
			leeDatoslog(n1);
			r = coseno(n1);
			cout << "El coseno es: " << r;
			_getch();
		break;
		case '8':
		case 't':
			leeDatoslog(n1);
			r = tangente(n1);
			cout << "El tangente es: " << r;
			_getch();
		break;
		case '9':
		case 'e':
			system("exit");
		}
	}while(resp!='E' && resp !='e' && resp!='9');

}
