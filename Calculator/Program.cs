using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Bem-vindo(a), selecione a função que deseja executar: ");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("--------------");

            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtração(); break;
                case 3: Divisão(); break;
                case 4: Multiplicação(); break;
                default: Menu(); break;
            }
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
            Menu();

        }
        static void Subtração()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {result} ");
            Console.ReadKey();
            Menu();
        }
        static void Divisão()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 / v2;

            Console.WriteLine($"O resultado da divisão é: {result}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicação()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é: {result}");
            Console.ReadKey();
            Menu();
        }

    }

}