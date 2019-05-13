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
            PrintArray(array);

        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ ", ");
            }
        }
    }
}
