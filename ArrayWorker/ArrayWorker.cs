using System;

namespace ArrayWorker_Task
{
    public class ArrayWorker
    {
        public int[] ReversArray(int[] x)
        {
            int[] array = new int[x.Length];
            for (int i = 0, j = array.Length-1; i <= x.Length-1; i++, j--)
            {
                array[i] = x[j];
            }
            string arrayToString = String.Join("|", array);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(arrayToString);
            return array;
        }
        public int[] ReversArray(int[]array, int index, int newValue)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Index is {index}, new value is {newValue}");
            int[] resault = new int[array.Length+1];
            for (int i = 0, j = array.Length-1; i <= array.Length; i++, j--)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (i == index)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    resault[i] = newValue;
                    Console.Write($"{resault[i]} ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    i++;
                }
                resault[i] = array[j];
                Console.Write($"{resault[i]} ");
            }
            Console.WriteLine();
            return resault;
        }
        public int[] CreateArray()
        {
            Random random = new Random();
            int[] array = new int[random.Next(0,50)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The array has {array.Length} of elements.");
            Console.ForegroundColor = ConsoleColor.Green;
            string arrayToString = String.Join("|", array);
            Console.WriteLine(arrayToString);
            return array;
        }
    }
}