// See https://aka.ms/new-console-template for more information
Console.WriteLine("");

Console.WriteLine("Ingrese la cantidad de números a evaluar:");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{
    int positivos = 0, negativos = 0, pares = 0, impares = 0;

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Ingrese el número {i + 1}:");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero > 0)
                positivos++;
            else if (numero < 0)
                negativos++;

            if (numero % 2 == 0)
                pares++;
            else
                impares++;
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número entero válido.");
            i--; // Disminuir el índice para repetir la iteración actual.
        }
    }

    Console.WriteLine("\nResultados:");
    Console.WriteLine($"Positivos: {positivos}");
    Console.WriteLine($"Negativos: {negativos}");
    Console.WriteLine($"Pares: {pares}");
    Console.WriteLine($"Impares: {impares}");
}
else
{
    Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
}