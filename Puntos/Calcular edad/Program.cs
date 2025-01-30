int edad=0, actual=2024, resultado=0;
Console.WriteLine("Programa que determine si una persona es mayor de edad o no teniendo en cuenta el año actual y su año de nacimiento");
Console.WriteLine("----------------------------------");
Console.WriteLine("Digite el año de nacimiento");
edad=int.Parse(Console.ReadLine());
resultado=actual-edad;
Console.WriteLine("----------------------------------");
if(resultado>=18){
    Console.WriteLine("usted es mayor de edad debido a que usted tiene "+resultado+" años.");
}
else{
    Console.WriteLine("usted es menor de edad debido a que usted tiene "+resultado+" años.");
}