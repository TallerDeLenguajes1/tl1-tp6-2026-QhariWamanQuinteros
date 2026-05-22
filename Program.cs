Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;

b = a;

Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);

int numero, invertido = 0, temp, digito;
bool resultado;
string s;
do
{
    Console.WriteLine("Ingrese un numero");
    s = Console.ReadLine();
    resultado = int.TryParse(s, out numero);
    if (resultado == true)
    {
        if (numero > 0)
        {
            temp = numero;
            while (temp > 0)
            {
                digito = temp % 10;
                invertido = invertido * 10 + digito;
                temp /= 10;
            }
            Console.WriteLine("Numero invertido: " + invertido);
        }
        else
        {
            Console.WriteLine("El numero debe ser mayor a 0.");
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado no es un numero.");
    }
} while (resultado != true || numero <= 0);
