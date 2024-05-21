
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
