using System;

namespace A133590.Ejercicio38
{
    class Program
    {
        static double validarIngreso(string ingreso)
        {
            double numero;
            while(!Double.TryParse(ingreso, out numero))
            {
                Console.Write("Ingreso inválido, intente nuevamente: ");
                ingreso = Console.ReadLine();
            }

            return numero;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 38");
            Console.WriteLine("Programa que recibe una serie ascendente de números. Se detiene si no es ascendente.");
            Console.Write("Por favor, ingrese el primer número de la serie: ");
            double anterior = validarIngreso(Console.ReadLine());
            double actual = anterior;
            do
            {
                anterior = actual;
                Console.Write("Por favor, ingrese otro número: ");
                actual = validarIngreso(Console.ReadLine());
            } while (actual > anterior);

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
