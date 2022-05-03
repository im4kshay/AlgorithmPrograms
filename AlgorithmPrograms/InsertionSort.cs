using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public static void InsSort(int[] numbers)
        {
            for(int i = 0; i < numbers.Length - 1 ; i++)
            {
                for(int j = i+1; j >0; j--)
                {
                    if(numbers[j - 1] > numbers[j])
                    {
                        int temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n=============================");
            Console.WriteLine("Sorted arrray of numbers is:");
            Console.WriteLine("=============================");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

        }
    }
}
