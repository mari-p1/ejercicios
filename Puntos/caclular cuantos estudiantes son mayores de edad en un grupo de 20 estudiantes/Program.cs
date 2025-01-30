int E=0, ma=0, me=0;
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("Programa que permita determinar cuantos estudiantes son mayores de edad en un grupo de 20 estudiantes.");
for (int i =1; i<=20;i++){
    Console.WriteLine("digite la edad del estudiante "+i);
    E=int.Parse(Console.ReadLine());
    if(E>=18){
        ma=ma+1;
    }
    else{
        me=me+1;
    }
    
}
Console.WriteLine("En la clase hay "+ma+" mayores de edad y "+me+" menores de edad");