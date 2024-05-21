using System;
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

int inv=0;
int num=0;
Console.WriteLine("Ingrese el valor del numero a invertir:");
string numero= Console.ReadLine();
bool result = int.TryParse(numero, out num);
if (result)
{
    while (num!=0)
    {
        int ult= num%10;
        inv= inv*10 + ult;
        num= num/10;
    }
    Console.WriteLine("El numero invertido es: "+inv);
}else
{
    Console.WriteLine("Error al ingresar el numero");
}

// CALCULADORA v2




int opcion;
double num1, final;

Console.WriteLine("1_valor absoluto");
Console.WriteLine("2_cuadrado");
Console.WriteLine("3_raiz cuadrada");
Console.WriteLine("4_seno");
Console.WriteLine("5_coseno");
Console.WriteLine("6_parte entera");
Console.WriteLine("Ingrese una opcion: ");
int.TryParse(Console.ReadLine(), out opcion);
switch (opcion){

case 1:
Console.WriteLine("Ingrese el numero 1:");
double. TryParse(Console.ReadLine(), out num1);
 final = Math.Abs((float)num1);
Console.WriteLine("el resultado es: "+final);
break;

case 2:
Console.WriteLine("Ingrese el numero 1:");
double. TryParse(Console.ReadLine(), out num1);
final= Math.Pow(num1,2);
Console.WriteLine("el resultado es: "+final);
break;

case 3:
Console.WriteLine("Ingrese el numero 1:");
double. TryParse(Console.ReadLine(), out num1);
final=Math.Sqrt(num1); 
Console.WriteLine("el resultado es: "+final);
break;


case 4:
Console.WriteLine("Ingrese el numero 1:");
double. TryParse(Console.ReadLine(), out num1);
final=Math.Sin(num1);
Console.WriteLine("el resultado es: "+final); 
break;

case 5:
Console.WriteLine("Ingrese el numero 1:");
double. TryParse(Console.ReadLine(), out num1);
final=Math.Cos(num1);
Console.WriteLine("el resultado es: "+final); 
break;


case 6:
Console.WriteLine("Ingrese el numero 1:");
double.TryParse(Console.ReadLine(), out num1);
final=Math.Floor (num1);
Console.WriteLine("la parte entera del numero es: "+final);
Console.WriteLine("Ingrese el numero 1:");
Console.WriteLine("el resultado es: "+final);
break;


}
