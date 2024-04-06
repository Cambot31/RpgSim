namespace RpgSim
{
    public class RandomArrayGenerator
    {
        public static int[] GenerateRandomArray(Random random, int length, int maxAggregateValue, int maxValuePerItem)
        {
            if (length <= 0 || maxAggregateValue <= 0 || maxValuePerItem <= 0)
            {
                throw new ArgumentException("Length, maxAggregateValue, and maxValuePerItem must be greater than 0");
            }

            var result = new int[length];
            var remainingValue = maxAggregateValue;

            for (var i = 0; i < length - 1; i++)
            {
                var maxValue = Math.Min(remainingValue - (length - i - 1), maxValuePerItem);
                result[i] = random.Next(0, maxValue + 1);
                remainingValue -= result[i];
            }

            // Ensure the last item is within the specified maxValuePerItem
            result[length - 1] = Math.Min(remainingValue, maxValuePerItem);

            // Shuffle the array to make the distribution more random
            ShuffleArray(random, result);

            return result;
        }

        private static void ShuffleArray<T>(Random random, T[] array)
        {
            var n = array.Length;
            while (n > 1)
            {
                var k = random.Next(n--);
                (array[n], array[k]) = (array[k], array[n]);
            }
        }
    }
}
