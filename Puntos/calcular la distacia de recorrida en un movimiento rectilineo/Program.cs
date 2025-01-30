// See https://aka.ms/new-console-template for more information
int velocidad=0, tiempo=0, resultado=0;
Console.WriteLine("programa que permite calcular la distacia de recorrida en un movimiento rectilineo");
Console.WriteLine("----------------------------------");
Console.WriteLine("Digite la velocidad");
velocidad=int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------");
Console.WriteLine("digite el tiempo");
tiempo=int.Parse(Console.ReadLine());
resultado=velocidad*tiempo;
Console.WriteLine("----------------------------------");
Console.WriteLine("El la distacia recorrida en un movimiento rectilineo es: "+resultado);
Console.WriteLine(velocidad+" * "+tiempo+" = "+resultado);
