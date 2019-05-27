using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateRandomArray(10);
            Console.WriteLine("Hello, this is sorting program");
            Console.WriteLine("This is our array: ");
            //Here print array before sort
            PrintArray(array);
            Console.WriteLine("This is sorted array");
            //Here print array after sort
            Insertionsort(array);
            PrintArray(array);
            array = CreateRandomArray(10);
            Console.WriteLine("This is our array: ");
            PrintArray(array);
            Console.WriteLine("This is sorted cocktail sort: ");
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
            Console.WriteLine();
        }
        public static void Insertionsort(int[] array)
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
            bool Swapped = true;
            int start = 0;
            int end = array.Length;
            while (Swapped)
            {
                Swapped = false;
                for (int i = start; i < end - 1; i++)
                {
                    if (array[i] > array[i + 1] ) 
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        Swapped = true;                        
                    } 
                }
                if (!Swapped)  break;
                end--;
                for (int i = end - 1; i > start; i--)
                {
                    if (array[i - 1] > array[i]) 
                    {
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        Swapped = true;
                    }
                }
                start++;
            }
        }
        public static int[] CreateRandomArray(int size) {
            Random randomGenerator = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = randomGenerator.Next() % (10 * size); 
            }
            return array;
        }
    }
}
