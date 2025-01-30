string g;
int  hombres=0, mujeres=0;
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("Programa que permita determinar cuantos hombres y mujeres hay en un curso de 25 estudiantes");
Console.WriteLine("Digite (H) si eres hombre y mujer (M) ");
for (int i =1; i<=25;i++){
    Console.WriteLine("Digite el sexo del estudiante numero "+i);
    g=Console.ReadLine();
    if(g=="H"){
        hombres=hombres+1;
    }
    else{
        mujeres=mujeres+1;
    }
    
}
Console.WriteLine("En la clase hay "+hombres+" hombres y "+mujeres+" mujeres.");