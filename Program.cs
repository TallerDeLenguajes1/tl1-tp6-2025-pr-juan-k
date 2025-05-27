using System.Security.AccessControl;

int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de a:" + b);



/*
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
*/

    Console.Write("Ingrese una cadena:");
    string cadena_1 = Console.ReadLine();
    int longitud_c1 = cadena_1.Length;
    Console.WriteLine("La longitud de la cadena es:{0}",longitud_c1);
    Console.Write("Ingrese una segunda cadena:");
    string cadena_2 = Console.ReadLine();
    string cadena_concatenada = cadena_1 + cadena_2;
    Console.WriteLine("Cadena concatenada: "+cadena_concatenada);
    Console.Write("\n\nIngrese el fragmento que desea extraer:");
    string fragmento = Console.ReadLine();
    int posicion = cadena_concatenada.IndexOf(fragmento);

    if (posicion != -1)
    {
        string extraido = cadena_concatenada.Substring(posicion,fragmento.Length);
        Console.WriteLine("Fragmento extraido:" + extraido);
    }else{
        Console.WriteLine("El texto no fue encontrado en la cadena");
    }
//Punto 4

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
Console.WriteLine("\nNúmero 1: " + num1.ToString());
Console.WriteLine("Número 2: " + num2.ToString());
Console.WriteLine("Resultado: " + resultado.ToString());

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
//punto 5
foreach (char c in cadena_1)
{
    Console.WriteLine(c);
}
//punto 6
Console.Write("Ingrese la palabra que desea buscar: ");
string? palabra = Console.ReadLine();

int index = 0;
int contador = 0;
List<int> posiciones = new List<int>();

while ((index = cadena_concatenada.IndexOf(palabra, index)) != -1)
{
    contador++;
    posiciones.Add(index);
    index += palabra.Length; 
}

if (contador > 0)
{
    Console.WriteLine($"La palabra '{palabra}' apareció {contador} vez/veces.");
    Console.WriteLine("Posiciones donde aparece (índice de inicio):");

    foreach (int pos in posiciones)
    {
        Console.WriteLine(pos);
    }
}
else
{
    Console.WriteLine($"La palabra '{palabra}' no se encontró en el texto.");
}

