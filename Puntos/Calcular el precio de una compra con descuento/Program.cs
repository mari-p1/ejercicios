int c=0, p=0, v=0, v1=0, v2=0;
string Nombre, m;
Console.WriteLine(" Programa para determinar cuánto pagara una persona por una compra de la cual se sabe la cantidad de artículos y el valorunitario. Se debe tener en cuenta que el almacén hace un 20% de descuento cuando la compra supera $100000.");
Console.WriteLine("----------------------------------");
Console.WriteLine("Digite la cantidad de cosas que compró");
c=int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------");
Console.WriteLine("lo que costó la unidad en pesos");
p=int.Parse(Console.ReadLine());
v=c*p;

if(v>=100000){
    v1=v*20/100;
    v2=v-v1;

    Console.WriteLine("----------------------------------");
    Console.WriteLine("Usted recibio un descuento del 20% por ende debe pagar: "+v2);
}
else{
    Console.WriteLine("Su compra fue de un total de: "+v);
}