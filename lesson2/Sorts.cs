using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public class Sorts
    {
        public static void swap(int[] arr, int a, int b)
        {
            int x = arr[a];
            arr[a] = arr[b];
            arr[b] = x;
        }
        //1
        public static void bubbleSort(int[] arr)
        {
            bool flag = true;
            for (int i = 0; i < arr.Length && flag; i++)
            {
                flag = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        flag = true;
                        swap(arr, j, j + 1);
                    }
                }
            }
        }
        //2
        public static void mergeSort(int[] arr)
        {
            mergeSort(arr, 0, arr.Length);
        }
        public static void mergeSort(int[] arr, int low, int high)
        {
            int n = high - low;
            if (n <= 1)
                return;
            int mid = (low + high) / 2;
            mergeSort(arr, low, mid);
            mergeSort(arr, mid, high);
            int i = low, j = mid, k = 0;
            int[] temp = new int[n];
            while (i < mid && j < high)
            {
                if (arr[i] < arr[j])
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }
            while (i < mid)
                temp[k++] = arr[i++];
            while (j < high)
                temp[k++] = arr[j++];
            for (int l = 0; l < n; l++)
            {
                arr[low + l] = temp[l];
            }
        }
        //3
        public static int BSA(int[] arr, int x)
        {
            return BSA(arr, 0, arr.Length - 1, x);
        }
        public static int BSA(int[] arr, int left, int right, int x)
        {
            if (right >= left)
            {
                int mid = (right + left) / 2;
                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return BSA(arr, left, mid - 1, x);
                return BSA(arr, mid + 1, right, x);
            }
            else
                return -1;
        }
    }
}
