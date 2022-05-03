using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("=-=-=-=-=-=-=-=Data Sructures Algorithm Programs=-=-=-=-=-=-=-=");

                Console.WriteLine("1.Binary Search\n2.InsertionSort\n3.Bubble Sort\n");
                Console.WriteLine("Enter Your Option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Please provide input search item:");
                        int searchItem= int.Parse(Console.ReadLine());
                        int[] arr = { 5, 11, 20, 25, 33, 49, 50, 62, 67, 73 };
                        int result = BinarySearch.BinSearch(arr, searchItem);
                        if(result<0)
                        {
                            Console.WriteLine($"{searchItem} is not fouund");
                        }
                        else
                        {
                            Console.WriteLine($"{searchItem} is found at index:{result}");
                        }
                        break; 

                    case 2:
                        Random rnd = new Random();
                        int[] numbers = new int[8];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = rnd.Next(1, 50);
                        }
                        Console.WriteLine("=============================");
                        Console.WriteLine("Unsorted array of numbers is:");
                        Console.WriteLine("=============================");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        InsertionSort.InsSort(numbers);
                        break;

                    case 3:
                        Console.WriteLine("Enter size of array:");
                        int size = Convert.ToInt32(Console.ReadLine());
                        int[] array = new int[size];
                        Console.WriteLine("Enter  integer elements of array:");
                        for (int i = 0; i < size; i++)
                        {
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("=============================");
                        Console.WriteLine("Unsorted array of numbers is:");
                        Console.WriteLine("=============================");
                        foreach (var arry in array)
                        {
                            Console.Write(arry + " ");
                        }
                        BubbleSort.BubbSort(array, size);
                        break;

                    default:
                        Console.WriteLine("-------Enter the valid option---");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
