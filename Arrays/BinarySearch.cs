using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Searching
{
    public class BinarySearch
    {
        public int BinarySearchMethod(List<int> arr, int target)
        {
            int left = 0;
            int right = arr.Count - 1;
            while (left <= right)
            {
                int mid = (left + ((right - left) >> 1));
                if(arr[mid] == target)
                    return mid;
                if (arr[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
