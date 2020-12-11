


// in this exercise I tried to creat a random array and sort them by "BUBBLE SORING " algorithm.

using System;
using System.Threading;

namespace BubbleSort
{
    public static class Sorting
    {
        /* public static void Print(this int[] data)
         {
             int[] obj = BubbleSort(data);
             Console.WriteLine("\nsorted members\n");
             for(int i=0;i<data.Length;i++)
             {
                 Console.Write(data[i] + "  ");
             }
         }*/


        public static int[] BubbleSort(this int[] data)
        {
            int N = data.Length;
            for (int i = N - 1; i > 0; i--)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int num = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = num;
                    }
                }
            }
            return data;

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\"Unsorted Random Numbers\"");
            int[] unsortedArray = new int[10];
            Random r = new Random();
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = r.Next(0, 20);
                Console.Write(unsortedArray[i] + " ");
            }
            int[] sortedArray = unsortedArray.BubbleSort();
            Console.WriteLine("\n\"BUBBLE SORTED\"");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

            //int[] ss =  Sorting.BubbleSort(unsortedArray);

            //unsortedArray.Print();
            // Sorting.Print(unsortedArray);
            int[] aa = unsortedArray.BubbleSort();



            Console.ReadKey();
        }
    }
}













