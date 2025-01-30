// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int sueldo=0, valor1=0, saludypension=25,resultado1=0,resultado=0;
Console.WriteLine("programa que determina el salario a pagar a un empleado depemdiendo de los dias trabajados ");
Console.WriteLine("----------------------------------");
Console.WriteLine("digite el sueldo diario");
sueldo=int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------");
Console.WriteLine("digite los dias trabajados");
valor1=int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------");
resultado=sueldo*valor1;
resultado1=resultado*saludypension/100;
Console.WriteLine("----------------------------------");
Console.WriteLine("su salario menos salud y pension es : "+resultado1);