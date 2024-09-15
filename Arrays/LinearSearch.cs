namespace Arrays.Searching
{
    public class LinearSearch
    {
        public int LinearSearchMethod(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i + 1;
                }
            }
            return -1;
        }


        //Do not use foreach loop for this case
        public int LinearSearchForEachloop(int[] arr, int target)
        {
            int index = 1;
            foreach (int num in arr)
            {
                if (num == target)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        //LINQ best preffered
        public int LinerSearchLinq(int[] arr, int target)
        {
            var result = arr.Select((num, index) => new { num, index }).FirstOrDefault(x => x.num == target);
            return result != null ? result.index+1 : -1;
        }
    }
}
