using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]
            {
                5,2,7,8,9
            };
            Console.WriteLine("Hello, this is sorting program");
            Console.WriteLine("This is our array: ");
            //Here print array before sort
            PrintArray(array);
            Console.WriteLine("This is sorted array");
            //Here print array after sort
            SortArray(array);
            PrintArray(array);
            Console.WriteLine("This is sorted cocktailsort");
            //Here print array after sort
            Cocktailsort(array);
            PrintArray(array);
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ ", ");
            }
        }
        public static void SortArray(int[] array)
        {
            for (int i = 1; i < array.Length; i++)               
            {
                int j = i;
                while(j > 0 && array[j - 1] > array[j])
                {
                    int Temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = Temp;
                    j--;

                }

            }
        }
        public static void Cocktailsort(int[] array)
        {
           
        }
        public static int[] CreateRandomArray(int size) {
            Random randomGenerator = new Random();
            randomGenerator.Next();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = randomGenerator.Next();
            }
            return array;
        }
    }
}
