using Shared;

do
{
    var a = ConsoleExtension.GetInt("Ingrese primer numero: ");
    var b = ConsoleExtension.GetInt("Ingrese segundo numero: ");
    if (b % a == 0)
    {
    Console.WriteLine($"El numero {a} es multiplo de {b}");
    }
    else
    {
    Console.WriteLine($"El numero {a} no es multiplo de {b}");
    }
} while (true);

    