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


Console.Write("Ingrese el primer numero:");
string? dato1 = Console.ReadLine();
int num1 = int.Parse(dato1);


Console.Write("Ingrese el segundo numero:");
string? dato2 = Console.ReadLine();
int num2 = int.Parse(dato2);

Console.Write("Ingrese que quiere hacer: 1-Sumar, 2-Resta, 3-Multiplicar, 4-Dividir");

string? dato = Console.ReadLine();
int eleccion = int.Parse(dato);

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
Console.Write(resultado);

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
Console.WriteLine("El valor absoluto de:" + resultado + "es" + resultado);
int cuadrado = resultado * resultado;
Console.WriteLine("El cuadrado de:"+resultado +"es"+cuadrado);
int raiz = resultado;
Console.WriteLine("El cuadrado de:"+resultado +"es"+raiz);



