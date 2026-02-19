using Shared;
using System;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{

    var name = ConsoleExtension.Getstring("Ingrese nombre........................: ");
    var workhours = ConsoleExtension.GetFloat("Ingrese numero de horas trabajadas....: ");
    var hourValue = ConsoleExtension.GetDecimal("Ingrese valor hora....................: ");
    var salaryMinimum = ConsoleExtension.GetDecimal("Ingrese valor salario mínimo mensual: ");

    var salary = (decimal)workhours * hourValue;
    if (salary < salaryMinimum)
    {
        Console.WriteLine($"Nombre...............................: {name}");
        Console.WriteLine($"Salario............................: {salaryMinimum:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre.................................: {name}");
        Console.WriteLine($"Salario...............................: {salary:C2}");
    }

     do
     {
         answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
     } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over");

