int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de a:" + b);


string? invertir;
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
Console.Write("El numero invertido:"+invertido);

