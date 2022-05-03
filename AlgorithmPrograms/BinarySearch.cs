using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class BinarySearch
    {
        public static int BinSearch(int[] arr, int searchItem)
        {
            int start = 0;
            int end = arr.Length - 1;
            while(start <= end)
            {
                int mid = (start + end) / 2;
                if(searchItem == arr[mid])
                {
                    return mid;
                }
                else if(searchItem < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
