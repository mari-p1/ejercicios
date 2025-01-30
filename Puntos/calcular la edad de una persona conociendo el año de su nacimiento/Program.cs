int edad=0, actual=2024, resultado=0;
Console.WriteLine("Programa que permite calcular la edad de una persona conociendo el año de su nacimiento");
Console.WriteLine("----------------------------------");
Console.WriteLine("Digite el año de nacimiento");
edad=int.Parse(Console.ReadLine());
resultado=actual-edad;
Console.WriteLine("----------------------------------");
Console.WriteLine("Su edad es: "+resultado);