namespace Insertion_Sort
{
    internal class Insertion_Sort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 2, 4, 6, 1, 3 };

            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int key = arr[i];

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }

            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
