namespace Algo
{
    public class Algorithms
    {
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while(left < right)
            {
                int middle = (right / 2) + left;

                if(arr[middle] > target) 
                    right--;

                if(arr[middle] < target) 
                    left++;

                if(arr[middle] == target) 
                    return middle;
            }

            return -1; // Not Found
        }
    }
}