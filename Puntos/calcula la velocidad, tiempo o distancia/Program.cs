int D, V, T, EL;
Console.WriteLine("Programa que realiza calcula la velocidad, tiempo o distancia");
Console.WriteLine(" ");
Console.WriteLine("Digite el numero para el que necesitas calcular:");
Console.WriteLine(" velocidad (1), tiempo (2) o distancia (3) ");
EL= int.Parse(Console.ReadLine());
Console.WriteLine(" ");
switch (EL){
    case 1:
    Console.WriteLine("Introduce la velocidad y el tiempo para calcular la distancia");
    Console.WriteLine("Tiempo");
    T= int.Parse(Console.ReadLine());
    Console.WriteLine("Velocidad");
    V= int.Parse(Console.ReadLine());
    D=T*V;
    Console.WriteLine("La distancia es: "+D);
    break;
    case 3:
    Console.WriteLine("Introduce la distancia y la velocidad para calcular el tiempo");
    Console.WriteLine("distancia");
    D= int.Parse(Console.ReadLine());
    Console.WriteLine("Velocidad");
    V= int.Parse(Console.ReadLine());
    T=D/V;
    Console.WriteLine("El tiempo es: "+T);
    break;
    case 2:
    Console.WriteLine("Introduce la distancia y el tiempo para calcular la velocidad");
    Console.WriteLine("distancia");
    D= int.Parse(Console.ReadLine());
    Console.WriteLine("Tiempo");
    T= int.Parse(Console.ReadLine());
    V=D/T;
    Console.WriteLine("El tiempo es: "+V);
    break;
}