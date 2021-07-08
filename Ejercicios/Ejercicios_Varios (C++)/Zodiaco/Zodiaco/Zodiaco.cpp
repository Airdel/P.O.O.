// Ejercicio c++ 2.cpp: Programa para determinar signo zodiacal.
//Developed by: Airdel

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

void main()
{
	locale::global(locale("spanish"));
	int mes, dia;
	char nombre[100];
	//inicio de programa
	cout << "-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-" << endl;
	cout << "Bienvenido, introduce tu nombre: ";
	cin.getline(nombre, 100);
	cout << "Bienvenido " << nombre << ". Introduce tu mes de nacimiento: ";
	cin >> mes;
	cout << "Ahora introduce tu dia de nacimiento: ";
	cin >> dia;
	
	switch( mes)
	{
	case 1://Enero
		if(dia<=20)
			cout<<"Eres Capricornio";
		else
		{
			cout<<"Eres Acuario";
		}
		break;
	case 2://Febrero
		if(dia<=18)
			cout<<"Eres Acuario";
		else
		{
			cout<<"Eres Piscis";
		}
		break;
	case 3://Marzo
		if(dia<=20)
			cout<<"Eres Piscis";
		else
		{
			cout<<"Eres Aries";
		}
		break;
	case 4://Abril
		if(dia<=20)
			cout<<"Eres Aries";
		else
		{
			cout<<"Eres Tauro";
		}
		break;
	case 5://Mayo
		if(dia>=1 && dia<=21)
			cout<<"Eres Tauro";
		else
		{
			cout<<"Eres Geminis";
		}
		break;
	case 6://Junio
		if(dia>=1 && dia<=21)
			cout<<"Eres Geminis";
		else
		{
			cout<<"Eres Cancer";
		}
		break;
	case 7://Julio
		if(dia>=1 && dia<=21)
			cout<<"Eres Cancer";
		else
			cout<<"eres Leo";
		break;
	case 8://Agosto
		if(dia>=1 && dia<=22)
			cout<<"Eres Leo";
		else
			cout<<"Eres Virgo";
		break;
	case 9://septiembre
		if(dia>=1 && dia<=22)
			cout<<"Eres Virgo";
		else
			cout<<"Eres Libra";
		break;
	case 10://octubre
		if(dia>=1 && dia<=23)
			cout<<"Eres Libra";
		else
			cout<<"Eres escorpio";
		break;
	case 11:
		if(dia>=1 && dia<=22)
			cout<<"Eres escorpio";
		else
			cout<<"Eres Sagitario";
		break;
	case 12:
		if(dia>=1 && dia<=22)
			cout<<"Eres Sagitario";
		else
			cout<<"Eres Capricornio";
		break;
	default:																								
		cout<<"LoL, creo que no.";
	}
	_getch();
}