int clL=0, clm=0, clm1=0, clj=0, clv=0, cls=0, cld=0, clsemana=0;
Console.WriteLine("Programa el cual permita ingresar los valores de temperatura de cada día durante una semana");
Console.WriteLine("----------------------------------");
Console.WriteLine("Ingrese la termperatura del clima durante toda la semana");
Console.WriteLine("lunes");
clL=int.Parse(Console.ReadLine());
Console.WriteLine("martes");
clm=int.Parse(Console.ReadLine());
Console.WriteLine("miercoles");
clm1=int.Parse(Console.ReadLine());
Console.WriteLine("jueves");
clj=int.Parse(Console.ReadLine());
Console.WriteLine("viernes");
clv=int.Parse(Console.ReadLine());
Console.WriteLine("sabado");
cls=int.Parse(Console.ReadLine());
Console.WriteLine("domingo");
cld=int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------");

clsemana=(clL+clm+clm1+clj+clv+cls+cld)/7;

if(clsemana<15){
    Console.WriteLine("----------------------------------");
    Console.WriteLine("que semana tan fria con "+clsemana+"° de promedio");
}
if(clsemana>=15 && clsemana<36){
    Console.WriteLine("----------------------------------");
    Console.WriteLine("que clima tan delicioso con "+clsemana+"° de promedio");
}
if(clsemana>=36){
    Console.WriteLine("----------------------------------");
    Console.WriteLine("que semana tan calurosa con "+clsemana+"° de promedio");
}