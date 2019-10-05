using System;

namespace binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci numero decimle");
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine($"{binary}");
            



        }
    }
    }
