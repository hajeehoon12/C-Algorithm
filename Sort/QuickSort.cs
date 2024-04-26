namespace AlgorithTest
{
    internal class QuickSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 2, 4, 6, 1, 3, 9, 8, 2, 3, 4,5, 6,7 };


            QuickSort(arr, 0, arr.Length - 1);

            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }

            
            void Swap(int[] arr , int i , int j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            int Partition(int[]arr , int left, int right)
            {
                int pivot = arr[right];
                int i = left;

                for (int j = left; j < right; j++)
                {
                    if (arr[j] < pivot)
                    {
                        
                        Swap(arr, i, j);
                        i++;
                        
                    }
                }

                Swap(arr, i, right);

                return i; // pivot
            }



            void QuickSort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition(arr, left, right);

                    QuickSort(arr, left, pivot - 1);
                    QuickSort(arr, pivot +1 , right);
                
                }
            
            }



        }
    }
}
