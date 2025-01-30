// See https://aka.ms/new-console-template for more information
int valor1=0, cantidad=0, iva=16, resultado=0,valor2=100,resultado1=0,resultado2=0;
Console.WriteLine("programa que permite a una tineda saber el valor que paga un cliente por varios productos inlcuyendo el iva ");
Console.WriteLine("----------------------------------");
Console.WriteLine("digite la cantidad de productos ");
cantidad=int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------");
Console.WriteLine("digite el precio de los productos");
valor1=int.Parse(Console.ReadLine());

resultado=cantidad*valor1;
resultado1=iva*resultado/valor2;
resultado2=resultado+resultado1;
Console.WriteLine("----------------------------------");
Console.WriteLine("El valor de la compra es: "+resultado2);
