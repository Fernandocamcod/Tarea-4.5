using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una serie de números (separados por espacios):");

        // Leer los números ingresados por el usuario
        string[] numerosStr = Console.ReadLine().Split();

        // Convertir los números a enteros y almacenarlos en un array
        int[] numeros = new int[numerosStr.Length];
        for (int i = 0; i < numerosStr.Length; i++)
        {
            numeros[i] = int.Parse(numerosStr[i]);
        }

        // Calcular la suma de los números
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        // Calcular el promedio
        double promedio = (double)suma / numeros.Length;

        // Mostrar el resultado
        Console.WriteLine($"El promedio de los números ingresados es: {promedio}");

        // Esperar a que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
    }
}