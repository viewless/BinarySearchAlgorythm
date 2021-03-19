using System;
using System.Linq;

namespace BinarySearchAlgorythm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.Write("Enter key: ");
            int key = int.Parse(Console.ReadLine());

            Array.Sort(numbers);
            //var sortedArray = numbers.OrderBy(x => x).ToArray();

            var result = BinarySearch(numbers, key);

            Console.WriteLine(result);

        }

        public static string BinarySearch(int[] inputNumbers, int key)
        {
            int left = 0;
            int right = inputNumbers.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (inputNumbers[mid] == key)
                {
                    return $"Your key was at position: {mid}";
                }
                else if (key < inputNumbers[mid] )
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return "Key not found.";
        }

    }
}
