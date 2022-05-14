using System;

namespace Metodos_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal, profesion, nombre, tela, cosa, lugar, verbo, comida;

            Console.WriteLine("Escribe un nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Escribe una profesion: ");
            profesion = Console.ReadLine();

            Console.WriteLine("Escribe una comida: ");
            comida = Console.ReadLine();

            Console.WriteLine("Escribe un tipo de tela: ");
            tela = Console.ReadLine();

            Console.WriteLine("Escribe el nombre de un lugar: ");
            lugar = Console.ReadLine();

            Console.WriteLine("Escribe el nombre de una cosa: ");
            cosa = Console.ReadLine();

            Console.WriteLine("Escribe un verbo: ");
            verbo = Console.ReadLine();

            Console.WriteLine("Escriba el nombre de un animal: ");
            animal = Console.ReadLine();

            Console.WriteLine(parte1(comida));
            Console.WriteLine(parte2(nombre));
            Console.WriteLine(parte3(lugar));
            Console.WriteLine(parte4(animal));
            Console.WriteLine(parte5(profesion));
            Console.WriteLine(parte6(cosa));
            Console.WriteLine(parte7(tela));
            Console.WriteLine(parte8(verbo));
        }

        static string parte1 (string comida){
            return "di " + comida + ", dijo el fotógrafo mientras la cámara destellaba! ";
            }
        static string parte2(string nombre)
        {
            return  nombre + " y había ido a";
        }
        static string parte3(string lugar)
        {
            return lugar + " para tomarnos fotos en mi cumpleaños.";
        }
        static string parte4(string animal)
        {
            return "La primera foto que realmente queríamos era una foto de nosotros vestidos como "+animal;
        }
        static string parte5(string profesion)
        {
            return " fingiendo ser una " + profesion+".";
        }
        static string parte6(string cosa)
        {
            return "Cuando vimos la segunda foto, era exactamente lo que quería. Ambos parecíamos " + cosa;
        }
        static string parte7(string tela)
        {
            return " vistiendo " + tela;
        }
        static string parte8(string verbo)
        {
            return " y " + verbo + " --exactamente lo que tenía en mente.";
        }
    }
}
