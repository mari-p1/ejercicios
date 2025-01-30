int e=0, a=0, p=0;
Console.WriteLine("Para saber si puede entrar en el equipo de bogotá ingrese los siguientes datos.");
Console.WriteLine("----------------------------------");
Console.WriteLine("Edad");
e=int.Parse(Console.ReadLine());
Console.WriteLine("Altura en cm");
a=int.Parse(Console.ReadLine());
Console.WriteLine("peso en kg");
p=int.Parse(Console.ReadLine());

if(e>17&&a>179&&p>79){
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Usted podrá entrar al equipo");
}
else{
    Console.WriteLine("----------------------------------");
    Console.WriteLine("No podrá entrar al equipo");
}