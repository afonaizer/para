using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 1

            //Console.Write("n=");
            //byte n = byte.Parse(Console.ReadLine());
            //int[] array = new int[6];
            //for (int i = 0; i < array.Length; i++) 
            //{
            //    Console.Write($" array[{i}]=");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i=0; i<array.Length; i++)
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}

            ////////задание2
            //Console.Write("n=");
            //byte n = byte.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //Random rnd= new Random();
            //for(int i=0;i<array.Length; i++)
            //{
            //    array[i] = rnd.Next(-10, 10);
            //}
            //foreach (int elem in array)
            //{
            //    Console.Write($"{elem}\t");
            //}

            ////ZADANIE3
            Console.Write("n=");
            byte n = byte.Parse(Console.ReadLine());
            int[] array = new int[n];
            int max = array[0];

                

        }
    }
}
