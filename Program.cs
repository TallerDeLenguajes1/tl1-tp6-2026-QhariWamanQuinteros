Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);
int numero, invertido = 0;
bool valido;
do
{
    Console.WriteLine("Ingrese un numero");
    valido = int.TryParse(Console.ReadLine(), out numero);
    if (!valido) // if (valido != true) ó if (valido == false) 
    {
        Console.WriteLine("El valor ingresado no es un numero.");
    }
    else
    {
        if (numero < 0)
        {
            Console.WriteLine("El numero debe ser mayor a 0.");
        }
        else
        {
            int temp = numero;
            while (temp > 0)
            {
                int digito = temp % 10;
                invertido = invertido * 10 + digito;
                temp /= 10;
            }
            Console.WriteLine("Numero invertido: " + invertido);
        }
    }
} while (!valido || numero <= 0);