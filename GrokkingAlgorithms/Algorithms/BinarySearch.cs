namespace GrokkingAlgorithms.Algorithms
{
    public class BinarySearch
    {
        public static int? Run(int[] data, int value)
        {
            var low = 0;
            var high = data.Length - 1;
            while (low <= high) 
            {
                var mid = (low + high) / 2;
                var current = data[mid];
                if (current == value) 
                {
                    return mid;
                }
                if (current < value) 
                {
                    low = mid + 1;
                }
                if (current > value)
                {
                    high = mid - 1;
                }
            }
            return null;
        }
    }
}
