// Dia semana.cpp: Aplicacion de impresion de mes.
//Developed by: Airdel
#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

void main()
{
	locale::global(locale("spanish"));
	cout<<"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::AirSu Software:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-"<<endl;
	cout<<endl;
	short mes;
	cout<<"Introduce el numero del mes: ";
	cin>>mes;
		if(mes==1)
			cout<<"Es enero (Invierno)";
		else
		{
			if(mes==2)
				cout<<"Es Febrero";
			else
			{
				if(mes==3)
					cout<<"Es Marzo";
				else
				{
					if(mes==4)
						cout<<"Es Abril (Primavera \._./)";
					else
					{
						if(mes==5)
							cout<<"Es Mayo";
						else
						{
							if(mes==6)
								cout<<"Es Junio";
							else
							{
								if(mes==7)
									cout<<"Es Julio (Verano /._./)";
								else
								{
									if(mes==8)
										cout<<"Es Agosto";
									else
									{
										if(mes==9)
											cout<<"Es Septiembre (Viva mexico(?))";
										else
										{
											if(mes==10)
												cout<<"Es Octubre (Otoño {._.} )";
											else
											{
												if(mes==11)
													cout<<"Es Noviembre";
												else
												{
													if(mes==12)
														cout<<"Es diciembre (Navidad \._.\)";
													else
													{
														if(mes>=13)
															cout<<"tah loko usteh'?"<<endl;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	_getch();
}
