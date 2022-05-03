using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class BubbleSort
    {
        public static void BubbSort(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n=============================");
            Console.WriteLine("Sorted arrray of numbers is:");
            Console.WriteLine("=============================");
            foreach (var arry in array)
            {
                Console.Write(arry + " ");
            }

        }
    }
}
