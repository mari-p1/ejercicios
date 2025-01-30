int ne=0;
float n1=0, n2=0, n3=0, r1=0;
string Nombre, m;
Console.WriteLine(" Programa en el cual reciba como entradas la siguiente información: Código del Estudiante, Nombre del Estudiante, Nombre de la Materia y Tres Notas de 1.0 a 5.0. Con esta información el programa debe calcular la nota definitiva (promedio) y determinar si el estudiante aprueba o no la materia ");
Console.WriteLine("----------------------------------");
Console.WriteLine("Digite el codigo de estudiante");
ne=int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------");
Console.WriteLine("Digite su nombre");
Nombre= Console.ReadLine();
Console.WriteLine("----------------------------------");
Console.WriteLine("Digite el nombre de la materia");
m= Console.ReadLine();
Console.WriteLine("----------------------------------");
Console.WriteLine("Digite tres notas suyas de esta materia de 1.0 a 5.0");
n1=float.Parse(Console.ReadLine());
n2=float.Parse(Console.ReadLine());
n3=float.Parse(Console.ReadLine());
r1=(n1+n2+n3)/3;
Console.WriteLine("----------------------------------");
Console.WriteLine("Estudiante "+Nombre+" con el numero de estudiante "+ne+", Usted obtuvo una nota definitiva de: "+r1);
if(r1<4){
    Console.WriteLine("Usted reprobó "+m);
}
if(r1>=4){
    Console.WriteLine("Usted aprobó "+m);
}