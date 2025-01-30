int numero=0;
Console.WriteLine("Programa para determinar si un número ualquiera ingresado por el usuario es o no positivo");
Console.WriteLine("----------------------------------");
Console.WriteLine("un numero");
numero=int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------");
if(numero>=1){
    Console.WriteLine("el número "+numero+" es positivo.");
};
if(numero<0){
    Console.WriteLine("el número "+numero+" es negativo");
};
if(numero==0){
    Console.WriteLine("el número "+numero+" no es negativo ni positivo porque el valor es nulo");
};