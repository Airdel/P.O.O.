//totalv_exam
//programa para calcular el total
//a pagar en la campra de algún tipo de articulo.

#include <iostream>
#include <conio.h>

void main()

{

	char nombreArticulo [100];
   float precioArt,subtotal,total;
   int cantArt;

   cout<<"¿Cual es el nombre del articulo? ";
   cin.getline(nombreArticulo,100);

   cout<<"¿Cuantos articulos? ";
   cin>>cantArt;

   (cantArt>=10) ? precioArt = 150 : precioArt = 170.0;
   subtotal = cantArt * precioArt;
   IVA = subtotal * 0.15;
   total = subtotal + IVA;

   cout<<"El total a pagar es: ";
   cout<<total;

}


