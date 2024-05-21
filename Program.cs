
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



int calcular;
Console.WriteLine("Ingrese un numero para: ");// 1 Entrar
string entra= Console.ReadLine();
bool calc = int.TryParse(entra, out calcular);
 
if (calc &&calcular == 1)
{
    bool seguir = true;

   while (seguir)
   {
int eligio;
Console.WriteLine("ELIJA LA OPERACION QUE HARA: "); // 0 SALIR 1 SUMA 2 RESTA 3 MULTIPLICAR 4 DIVIDIR
string elige= Console.ReadLine();
bool result2= int.TryParse(elige, out eligio);
    
   if (result2)
   {
    Console.WriteLine("Ingrese 2 NUmeros");
    int finaliza;
    int Num1;
    int num2;
    string Num11 = Console.ReadLine();
    string num22= Console.ReadLine();
    bool salida= int.TryParse(Num11, out Num1 );
    bool salida2= int.TryParse(num22,out num2);
    if(salida&&salida2){

    switch (eligio)
    {
        case 1:  finaliza= Num1+ num2;
                Console.WriteLine("EL RESULTADO ES: "+finaliza);
        break;
        case 2:
         finaliza= Num1 -num2;
                Console.WriteLine("EL RESULTADO ES: "+finaliza);
    

        break;
        case 3:
         finaliza= Num1 *num2;
                Console.WriteLine("EL RESULTADO ES: "+finaliza);

        break;
        case 4:
          finaliza= Num1 /num2;
                Console.WriteLine("EL RESULTADO ES: "+finaliza);
        break;
       
    }

    }
    
    
   }
     

   }
}
