int a=0, b=20, c=100, resultado=0, d=0;
Console.WriteLine("Programa para calcular el 20% de cualquier numero");
Console.WriteLine("----------------------------------");
Console.WriteLine("Digite el numero");
a=int.Parse(Console.ReadLine());
resultado=a*b;
d=resultado/c;
Console.WriteLine("----------------------------------");
Console.WriteLine("El 20% de "+a+" es: "+d);