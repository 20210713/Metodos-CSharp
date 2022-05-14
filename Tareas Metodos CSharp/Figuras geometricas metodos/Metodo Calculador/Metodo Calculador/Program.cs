using System;

namespace Metodo_Calculador
{
    class Program
    {
            public static void Suma(int a, int b)
            {
                int result = a + b;
                Console.WriteLine($"Suma: {result}");
            }
            public static int Multiplicacion(int a, int b)
            {
                int result = a * b;
                return result;
            }
            public static int Resta(int a, int b)
            {
                int result = a - b;
                return result;
            }
            public static float Division(float a, float b)
            {
                float result = a / b;
                return result;
            }
            static void Main(string[] args)
            {
                int num1, num2;
                Console.WriteLine("escriba el primer numero");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("escriba el segundo numero");
                num2 = int.Parse(Console.ReadLine());
                Suma(num1, num2);
                Console.WriteLine($"Resta: {Resta(num1, num2)}");
                Console.WriteLine($"Multiplicacion: {Multiplicacion(num1, num2)}");
                Console.WriteLine($"Division: {Division(num1, num2)}");
            }
        }
    }
