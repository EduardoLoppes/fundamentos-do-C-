using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
            Subtração();
            Divisão();
            Multiplicação();
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 + v2;
            Console.WriteLine($"O resultado é: {result}");
            Console.ReadKey();

        }
        static void Subtração(){
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1-v2;
            Console.WriteLine($"O resultado da subtração é: {result} ");
            Console.ReadKey();
        }
        static void Divisão(){
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1/v2;

            Console.WriteLine($"O resultado da divisão é: {result}");
            Console.ReadKey();
        }
        static void Multiplicação(){
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1*v2;

            Console.WriteLine($"O resultado da multiplicação é: {result}");
            Console.ReadKey();
        }
    }

}