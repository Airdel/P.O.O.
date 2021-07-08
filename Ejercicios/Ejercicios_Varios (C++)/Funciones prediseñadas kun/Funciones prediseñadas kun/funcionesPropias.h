#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <cmath>
#include "string.h"
using namespace std;

double mayor2numeros(double n1,double n2)
{
	if(n1 > n2)
	return n1;
	else
	return n2;
}
//-----------------------------..
double mayor2num(double x, double y)
{
	return (x>y)?x : y ;
}
//----------------------------..
double mayor3(double x, double y, double z)
{
	if(x > y && x > z)
		return x;
	else if (y > z)
			return y;
		 else
			return z;
}
//-----------------------------..
double Factorial(long num)
{
	double fac = 1;
	for(int x=2; x <= num ; x++)
		fac = fac * x;
	return fac;
}