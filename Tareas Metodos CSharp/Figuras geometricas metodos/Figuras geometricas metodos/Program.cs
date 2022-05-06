using System;

namespace Figuras_geometricas_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, h;

            //Cuadrado
            Console.WriteLine("Escriba el lado del Cuadrado");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del Cuadrado es: {cuadrado(a)}");

            //Rectangulo
            Console.WriteLine("Escriba la base del Rectangulo");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura del Rectangulo");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del Rectangulo es: {rectangulo(a,b)}");

            //Triangulo
            Console.WriteLine("Escriba la base del Triagulo");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura del Triangulo");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del Triangulo es: {triangulo(a,b)}");

            //Circulo
            Console.WriteLine("Escriba el radio del Circulo");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine($"El diametro del Circulo es: {circulo(a)}");

            //Trapezio
            Console.WriteLine("Escriba la base mayor del Trapezio");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la base menor del Trapezio");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura del Trapecio");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del Trapecio es: {trapecio(a,b,h)}");
        }

        static float cuadrado(float a)
        {
            return a * a;
        }

        static float rectangulo(float a, float b)
        {
            return a * b;
        }
        static float triangulo(float a, float b)
        {
            return (a * b) / 2;
        }
        static float circulo(float a)
        {
            return 2 * a;
        }
        static float trapecio(float a, float b, float h)
        {
            return h * ((a + b) / 2);
        }
    }
}
