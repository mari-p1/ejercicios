Console.WriteLine("Programa que permita obtener el cubo,la cuarta y la quinta potencia de N númerosingresados por el usuario");
float n=0, a=0, b=0, c=0, v=0;
Console.WriteLine("Digite la cantidad de notas que va a digitar");
v=float.Parse(Console.ReadLine());

while(n<v){
    n++;
    Console.WriteLine("Digite nota numero "+n);
    a=float.Parse(Console.ReadLine());
    b=b+a;
}
c=b/v;
Console.WriteLine("La definitiva fue "+c);