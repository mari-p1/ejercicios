int edad=0,sum=0;
int  hombres=0, mujeres=0;
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine(" Programa para calcular la edad promedio de un grupo de 15 estudiantes. ");
//Console.WriteLine("Digite su edad ");
for (int i =1; i<=3;i++){
    Console.WriteLine("Digite la edad del estudiante "+i);
    edad=int.Parse(Console.ReadLine());
    sum=sum+edad;
    
}
Console.WriteLine(sum);
//Console.WriteLine("En la clase la edad promedio es  "+edad);