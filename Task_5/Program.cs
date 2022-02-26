using ArrayWorker_Task;
using System;
using Cone;

namespace Task_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ArrayWorker arr = new ArrayWorker();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\tHey! This application contains two class libraries: " +
                "\n\tOne (arrays) does not contain a constructor and the methods are public." +
                "\n\tThe second contains a constructor and two public fields.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Create an array of random size and fill with random numbers:");
            int [] array = arr.CreateArray();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Invert the array and output to the console:");
            array = arr.ReversArray(array);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add a new value to the array at the specified index (random value to random index):");
            array = arr.ReversArray(array, rnd.Next(0, array.Length), rnd.Next());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("I have created a class with a constructor that takes two double type parameters. Methods are private:" +
                "\n(We use random parameters)");

            Cones con = new Cones(rnd.NextDouble(), rnd.NextDouble());

            Console.ResetColor();
        }
    }
}