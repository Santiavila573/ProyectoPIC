using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a SistemaLinealPro: Soluciones Directas en C#");

        // Solicitar al usuario los coeficientes de la función lineal
        Console.Write("Ingrese el valor de (m): ");
        double pendiente = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de (b): ");
        double ordenadaOrigen = Convert.ToDouble(Console.ReadLine());

        // Crear una instancia de la clase FuncionLinealGeneral
        FuncionLinealGeneral funcionLineal = new FuncionLinealGeneral(pendiente, ordenadaOrigen);

        // Solicitar al usuario un valor para x y calcular y
        Console.Write("Ingrese un valor para x: ");
        double valorX = Convert.ToDouble(Console.ReadLine());

        // Calcular y mostrar el resultado
        double resultadoY = funcionLineal.CalcularY(valorX);
        Console.WriteLine($"Para x = {valorX}, y = {resultadoY}");
    }
}