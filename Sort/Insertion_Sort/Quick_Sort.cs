namespace AlgorithTest
{
    internal class Quick_Sort
    {
        

        static void Main(string[] args)
        {

            void Swap(int[] arr, int i, int j) // 배열 내부 값 swap 용
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            int Partition(int[] arr, int left, int right) // 내부 분할
            {
                int pivot = arr[right]; // 우측 pivot 기준
                int i = left;

                for (int j = left; j < right; j++)
                {
                    if (arr[j] < pivot)
                    {
                        Swap(arr, i, j);
                        i++;
                    }
                }

                Swap(arr, i, right); // 기존 pivot을 i 우측에 배치

                return i; // 다음 함수 실행의 pivot 값
            }



            void QuickSort(int[] arr, int left, int right) // 분할정복
            {
                if (left < right)
                {
                    int pivot = Partition(arr, left, right);

                    QuickSort(arr, left, pivot - 1);
                    QuickSort(arr, pivot + 1, right);

                }

            }

            int[] arr = new int[] { 5, 2, 4, 6, 1, 3, 9, 8, 2, 3, 4, 5, 6,7 };


            QuickSort(arr, 0, arr.Length - 1);
        
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }

        }
    }
}
