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
        if (numero <= 0)
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
int opcion;
float num1, num2 = 0, resultado = 0;
string textoNum1, textoNum2;
do
{
    do
    {
        Console.WriteLine("Ingrese la operacion que desea realizar");
        Console.WriteLine("\t1. Sumar");
        Console.WriteLine("\t2. Restar");
        Console.WriteLine("\t3. Multiplicar");
        Console.WriteLine("\t4. Dividir");
        Console.WriteLine("\t5. Calcular el valor absoluto de un numero");
        Console.WriteLine("\t6. Calcular el cuadrado de un numero");
        Console.WriteLine("\t7. Calcular la raiz cuadrada de un numero");
        Console.WriteLine("\t8. Calcular el seno de un angulo");
        Console.WriteLine("\t9. Calcular el coseno de un angulo");
        Console.WriteLine("\t10. Calcular la parte entera de un numero");
        valido = int.TryParse(Console.ReadLine(), out opcion);
        if (!valido)
        {
            Console.WriteLine("El valor ingresado no es un numero.");
        }
        else
        {
            if (opcion < 1 || opcion > 10)
            {
                Console.WriteLine("El numero ingresado no es una opcion valida");
            }
        }
    } while (!valido || opcion < 1 || opcion > 10);
    do
    {
        Console.WriteLine("Ingrese un numero");
        valido = float.TryParse(Console.ReadLine(), out num1);
        if (!valido)
        {
            Console.WriteLine("El valor ingresado no es un numero.");
        }
    } while (!valido);
    if (opcion > 0 && opcion < 5)
    {
        do
        {
            Console.WriteLine("Ingrese otro numero");
            valido = float.TryParse(Console.ReadLine(), out num2);
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
    }
    textoNum1 = num1.ToString();
    textoNum2 = num2.ToString();
    switch (opcion)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine($"La suma de {textoNum1} y {textoNum2} es {resultado.ToString()}");
            break;
        case 2:
            resultado = num1 - num2;
            Console.WriteLine($"La resta de {textoNum1} y {textoNum2} es {resultado.ToString()}");
            break;
        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"La multiplicacion de {textoNum1} y {textoNum2} es {resultado.ToString()}");
            break;
        case 4:
            resultado = num1 / num2;
            Console.WriteLine($"La division de {textoNum1} y {textoNum2} es {resultado.ToString()}");
            break;
        case 5: resultado = Math.Abs(num1); break;
        case 6: resultado = (float)Math.Pow(num1, 2); break;
        case 7: resultado = (float)Math.Sqrt(num1); break;
        case 8: resultado = (float)Math.Sin(num1 * Math.PI / 180); break;
        case 9: resultado = (float)Math.Cos(num1 * Math.PI / 180); break;
        case 10: resultado = (int)Math.Truncate(num1); break;
    }
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
do
{
    Console.WriteLine("Ingrese un numero");
    valido = float.TryParse(Console.ReadLine(), out num1);
    if (!valido)
    {
        Console.WriteLine("El valor ingresado no es un numero.");
    }
} while (!valido);
do
{
    Console.WriteLine("Ingrese un numero");
    valido = float.TryParse(Console.ReadLine(), out num2);
    if (!valido)
    {
        Console.WriteLine("El valor ingresado no es un numero.");
    }
} while (!valido);
if (num1 > num2)
{
    Console.WriteLine("El maximo es " + num1 + " y el minimo es " + num2);
}
if (num1 < num2)
{
    Console.WriteLine("El maximo es " + num2 + " y el minimo es " + num1);
}
if (num1 == num2)
{
    Console.WriteLine("Ambos numeros son iguales");
}