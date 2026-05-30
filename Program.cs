Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);
int numero, temp, digito, invertido = 0;
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
            temp = numero;
            while (temp > 0)
            {
                digito = temp % 10;
                invertido = invertido * 10 + digito;
                temp /= 10;
            }
            Console.WriteLine("Numero invertido: " + invertido);
        }
    }
} while (!valido || numero <= 0);
int opcion, num1, num2, resultado = 0;
do
{
    do
    {
        Console.WriteLine("Ingrese la operacion que desea realizar");
        Console.WriteLine("\t1. Sumar");
        Console.WriteLine("\t2. Restar");
        Console.WriteLine("\t3. Multiplicar");
        Console.WriteLine("\t4. Dividir");
        valido = int.TryParse(Console.ReadLine(), out opcion);
        if (!valido)
        {
            Console.WriteLine("El valor ingresado no es un numero.");
        }
        else
        {
            if (opcion < 1 || opcion > 4)
            {
                Console.WriteLine("El numero ingresado no es una opcion valida");
            }
        }
    } while (!valido || opcion < 1 || opcion > 4);
    do
    {
        Console.WriteLine("Ingrese un numero");
        valido = int.TryParse(Console.ReadLine(), out num1);
        if (!valido)
        {
            Console.WriteLine("El valor ingresado no es un numero.");
        }
    } while (!valido);
    do
    {
        Console.WriteLine("Ingrese otro numero");
        valido = int.TryParse(Console.ReadLine(), out num2);
        if (!valido)
        {
            Console.WriteLine("El valor ingresado no es un numero.");
        }
        else
        {
            if (num2 == 0 && opcion == 4)
            {
                Console.WriteLine("La division entre 0 (cero) no esta definida");
            }
        }
    } while (!valido || (num2 == 0 && opcion == 4));
    switch (opcion)
    {
        case 1: resultado = num1 + num2; break;
        case 2: resultado = num1 - num2; break;
        case 3: resultado = num1 * num2; break;
        case 4: resultado = num1 / num2; break;
    }
    Console.WriteLine("El resultado es " + resultado);
    do
    {
        Console.WriteLine("Desea realizar otra operacion?");
        Console.WriteLine("\t1. Si");
        Console.WriteLine("\t2. No");
        valido = int.TryParse(Console.ReadLine(), out opcion);
        if (!valido)
        {
            Console.WriteLine("El valor ingresado no es un numero.");
        }
        else
        {
            if (opcion < 1 || opcion > 2)
            {
                Console.WriteLine("El numero ingresado no es una opcion disponible");
            }
        }
    } while (!valido || opcion < 1 || opcion > 2);
} while (opcion != 2);