using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace CS3310Project1Quicksort
{
    class Program
    {
        public static int count;
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Math.Pow(2, 3));
            int []arr = new int[size];
            var rand = new Random();
            for (int i = 0; i < Math.Pow(2, 3); i++)
            {
                arr[i] = (rand.Next());
            }
            int n = arr.Length;

            Console.WriteLine("The given array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            QuickSort(arr, 0, n - 1);


            Console.WriteLine("\nThe sorted array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("\n The number of times the basic operation is performed: {0}", count);
        }

        public static int partition(int []array, int low, int high)
        {
            int i = (low - 1); // index of smaller element
            int pivot = array[high];

            for(int j = low; j < high; j++)
            {
                // if current element is smaller than or equal to pivot
                if(array[j] < pivot)
                {
                    // increment index of smaller element
                    i++;
                    int tempArray = array[i];
                    array[i] = array[j];
                    array[j] = tempArray;
                }
            }
            int tempArray1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = tempArray1;
            return i + 1;
        }

        public static void QuickSort(int []array, int low, int high)
        {

            if(low < high)
            {
                // array[p] is now in right place
                int partitionIndex = partition(array, low, high);
                // separately sort elemnts before and after partition
                QuickSort(array, low, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, high);
            }
            count++;
        }
    }

}
