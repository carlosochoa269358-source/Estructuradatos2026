using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var a = ConsoleExtension.GetInt("Ingrese primer numero: ");
    var b = ConsoleExtension.GetInt("Ingrese segundo numero: ");
    if (b % a == 0)
    {
        Console.WriteLine($"El numero {a} es multiplo de: {b}");
    }
    else
    {
        Console.WriteLine($"El numero {a} No es multiplo de: {b}");
    }

{
    answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase))) ;

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;

Console.WriteLine("Game Over");



