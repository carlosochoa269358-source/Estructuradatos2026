using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("ingrese tres numeros diferentes");
    var a = ConsoleExtension.GetInt("Ingrese primer numero: ");
    var b = ConsoleExtension.GetInt("Ingrese segundo numero: ");
    var c = ConsoleExtension.GetInt("Ingrese tercer numero: ");

    int[] numeros = { a, b, c };


    Array.Sort(numeros);

    var menor = numeros[0];
    var medio = numeros[1];
    var mayor = numeros[2];

    Console.WriteLine($"El numero mayor es {mayor}");
    Console.WriteLine($"El numero medio es {medio}");
    Console.WriteLine($"El numero menor es {menor}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over");
