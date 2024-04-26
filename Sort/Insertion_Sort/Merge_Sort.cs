using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Merge_Sort
    {
        static void Main(string[] args)
        {

            static void MergeSort(int[] arr, int left, int right)
            {
                if (left < right) // 배열에 하나남을때까지 계속 진행
                {
                    int mid = (left + right) / 2;

                    MergeSort(arr, left, mid);
                    MergeSort(arr, mid + 1, right);
                    Merge(arr, left, mid, right);
                }
            }

            static void Merge(int[] arr, int left, int mid, int right)
            {
                int[] temp = new int[arr.Length]; // 담을 임시함수 생성 

                int i = left;            // 처음부터 진행 , 왼쪽
                int j = mid + 1;         // 중간부터 진행 , 오른쪽
                int k = left;

                while (i <= mid && j <= right) // mid 기준으로 나눠서 진행 , 둘 중 먼저 끝나면 비교를 멈춤
                {
                    if (arr[i] <= arr[j])     // 둘 중 작은수를 임시함수에 먼저박음
                    {
                        temp[k++] = arr[i++];
                    }
                    else
                    {
                        temp[k++] = arr[j++];
                    }
                }

                while (i <= mid)             // 남은것들 잔반처리1 (우측이 먼저 비어졌을때)
                {
                    temp[k++] = arr[i++];
                }

                while (j <= right)        //  남은것들 잔반처리 2 (좌측이 먼저 비어졌을때)
                {
                    temp[k++] = arr[j++];
                }

                for (int l = left; l <= right; l++) // array에 left부터 right까지만 바꾸었던 값만을 바꿔넣음
                {
                    arr[l] = temp[l];
                }
            }

            int[] arr = new int[] { 5, 2, 4, 6, 1, 3 };

            MergeSort(arr, 0, arr.Length - 1);

            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }


        }
    }
}
