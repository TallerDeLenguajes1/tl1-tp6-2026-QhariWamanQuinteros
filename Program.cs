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
bool valido2;
Console.WriteLine("Ingrese una cadena de texto");
string textoIngresado = Console.ReadLine();
Console.WriteLine("La longitud de la cadena ingresada es " + textoIngresado.Length);
Console.WriteLine("Ingrese otra cadena de texto");
string textoIngresado2 = Console.ReadLine();
//string ingresosConcatenados = textoIngresado + textoIngresado2;
//string ingresosConcatenados = string.Concat(textoIngresado, textoIngresado2);
string ingresosConcatenados = $"{textoIngresado} {textoIngresado2}";
Console.WriteLine($"Las cadenas concatenadas son: {ingresosConcatenados}");
do
{
    Console.WriteLine("Ingrese la posición inicial:");
    valido = int.TryParse(Console.ReadLine(), out a);
    Console.WriteLine("Ingrese la cantidad de caracteres a extraer:");
    valido2 = int.TryParse(Console.ReadLine(), out b);
    if (valido && valido2 && a >= 0 && b > 0 && a + b <= ingresosConcatenados.Length)
    {
        string subcadena = ingresosConcatenados.Substring(a, b);
        Console.WriteLine("La subcadena extraída es: " + subcadena);
    }
    else
    {
        Console.WriteLine("Error.\nLos valores ingresados no son válidos.");
    }
} while (!valido || !valido2 || a < 0 || b <= 0 || a + b > ingresosConcatenados.Length);
foreach (char letra in textoIngresado)
{
    Console.WriteLine($"{letra}");
}
Console.WriteLine("Ingrese una letra, palabra o parte del texto que quiera remplazar");
string textoARemplazar = Console.ReadLine();
Console.WriteLine("Ingrese el texto por el que desea remplazar el texto ingresado");
string textoReemplazo = Console.ReadLine();
string nuevoTexto = textoIngresado.Replace(textoARemplazar, textoReemplazo);
Console.WriteLine($"El nuevo texto es {nuevoTexto}");
