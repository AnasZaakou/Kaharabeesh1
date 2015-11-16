using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class SortSearch
    {
        public static void Bubble(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1 - i; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        int temp = Arr[j + 1];
                        Arr[j+1]= Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            DisplayArray(Arr);
        }
        // Has a Problem
        public static void Selection(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                int SmallestIndex = i;
                int j;
                for (j = 0+i; j < Arr.Length - 1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        SmallestIndex = j + 1;
                    }
                }
                if (SmallestIndex != i)
                {
                    int temp = Arr[SmallestIndex]; // Retain Smaller
                    Arr[SmallestIndex] = Arr[i];
                    Arr[i] = temp;
                }
            }
            DisplayArray(Arr);
        }
        public void Merge(int[] A, int[] B, int mid)
        {
            if (B[0] <= A[0])
            {
                for (int i = 0; i < B.Length; i++)
                {
                    int temp = A[i];
                    A[i] = B[i];
                    A[i + B.Length] = B[i];
                }
            }
            else if (B[B.Length - 1] >= A[A.Length - 1])
            {
                for (int i = 0; i < B.Length; i++)
                {
                    A[i + B.Length] = B[i];
                }
            }
            else
            {
                mid = mid/2;
            }
        }
        
        private static void DisplayArray(int[] Arr)
        {
            for (int x = 0; x < Arr.Length; x++)
            {
                Console.WriteLine(Arr[x]);
            }
        }

    }
}
