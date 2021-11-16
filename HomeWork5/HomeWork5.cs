using System;

namespace HomeWork5
{
    public class HomeWork5
    {
        private static void ArrayGenerate(ref int[] A, int size)
        {
            A = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                A[i] = random.Next(0, 100);
            }
        }

        public static int ArrayMin(int[] A)
        {
            int min = 0;
            min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
            }

            return min;
        }

        public static int ArrayMax(int[] A)
        {
            int max = 0;
            max = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }

            return max;
        }

        public static int ArrayMinID(int[] A)
        {
            int min = 0;
            int minID = 0;
            min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    minID = i;
                }
            }

            return minID;
        }

        public static int ArrayMaxID(int[] A)
        {
            int max = 0;
            int maxID = 0;
            max = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    maxID = i;
                }
            }

            return maxID;
        }

        public static int SumOddID(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += A[i];
                }
            }

            return sum;
        }

        public static int[] ArrayReverse(int[] A)
        {
            int i = 0;
            int j = A.Length - 1;
            while (i < j)
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
                i++;
                j--;
            }

            return A;
        }

        public static int CountOdd(int[] A)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] ArrayHalfSwap(int[] A)
        {
            int count1 = 0;
            int count2 = (A.Length + 1) / 2;
            while (count2 < A.Length)
            {
                int temp = A[count1];
                A[count1] = A[count2];
                A[count2] = temp;
                count1++;
                count2++;
            }

            return A;
        }

        public static int[] ArrayBubleSortUp(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }

            return A;
        }

        public static int[] ArrayInsertSortDown(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                int key = A[i];
                int j = i;
                while ((j > 1) && A[j - 1] > key)
                {
                    int temp = A[j - 1];
                    A[j - 1] = A[j];
                    A[j] = temp;
                    j--;
                }

                A[j] = key;
            }

            return A;
        }
    }
}
