using System.Security.AccessControl;

int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de a:" + b);



/*string? invertir;
Console.Write("Ingrese un numero:");
invertir = Console.ReadLine();
int numero = int.Parse(invertir);

int invertido = 0;
while (numero > 0)
{
    int dig = numero % 10;
    invertido = (invertido * 10) + dig;
    numero = numero / 10;
}
Console.Write("El numero invertido:"+invertido);*/

int num1 = 0,num2 = 0,eleccion = 0;
do
{
    Console.Write("Ingrese el primer numero:");
    string? dato1 = Console.ReadLine();
    num1 = int.Parse(dato1);
} while (num1 == 0 );


do
{
    Console.Write("Ingrese el segundo numero:");
    string? dato2 = Console.ReadLine();
    num2 = int.Parse(dato2);
} while (num2 == 0);

do
{
    Console.Write("1-Sumar, 2-Resta, 3-Multiplicar, 4-Dividir \n Ingrese que quiere hacer: ");
    string? dato = Console.ReadLine();
    eleccion = int.Parse(dato);
} while (eleccion < 1 || eleccion > 4);

int resultado = 0;

switch (eleccion)
{
    case 1:
        resultado = Sumar(num1, num2);
        break;

    case 2:
        resultado = Restar(num1, num2);
        break;

    case 3:
        resultado = Multiplicar(num1, num2);
        break;

    case 4:
        resultado = Dividir(num1, num2);
        break;
    
    default:
        break;
}
Console.Write("El resultado es:{0} \n\n",resultado);

int Sumar(int a, int b)
{
    return a + b;
}
int Restar(int a, int b)
{
    return a - b;
}
int Multiplicar(int a, int b)
{
    return a * b;
}
int Dividir(int a, int b)
{
    return a / b;
}
Console.WriteLine("El valor absoluto de:" + resultado + " es " + resultado);
int cuadrado = resultado * resultado;
Console.WriteLine("El cuadrado de:"+resultado +" es "+cuadrado);
double raiz = Math.Sqrt(Convert.ToDouble(resultado));
Console.WriteLine("El cuadrado de:"+resultado +" es "+raiz);
double seno = Math.Sin(Convert.ToDouble(resultado));
Console.WriteLine("El seno de resutado es:{0}",seno);
double coseno = Math.Cos(Convert.ToDouble(resultado));
Console.WriteLine("El coseno de resutado es:{0}",coseno);
int entero = Convert.ToInt32(resultado);
Console.WriteLine("La parte entera de un Flotante es:{0}",entero);

// solisito 2 numeros
Console.Write("1-Ingrese un número: ");
int num_1 = int.Parse(Console.ReadLine());

Console.Write("2-Ingrese otro número: ");
int num_2 = int.Parse(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine("{0}-Es el numero mayor",num_1);
    Console.WriteLine("{0}-Es el numero menor",num_2);
}else{
    Console.WriteLine("{0}-Es el numero mayor",num_2);
    Console.WriteLine("{0}-Es el numero menor",num_1);
}


