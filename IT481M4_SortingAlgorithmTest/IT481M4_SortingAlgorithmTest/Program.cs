using System;
using System.Data;

namespace SortingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////
            ///IT481M4 Algorithms for Analysis and Optimization///
            ///////////////////V3 Merge Sort//////////////////////
            //////////////////////////////////////////////////////

            ///Note: Merge Sort was created by John Von Neumann in 1945 as a divide and conquer sorting method with an average complexity of O(n log(n)) https://developer.nvidia.com/blog/merge-sort-explained-a-data-scientists-algorithm-guide/

            //Merge Sort Execution Time for Small Data Set
            int[] smallDataSet = DataSets.smallDataSet;
            var executionTimeSmall = System.Diagnostics.Stopwatch.StartNew();
            MergeSort(smallDataSet);
            executionTimeSmall.Stop();

            
            //Merge Sort Execution Time for Medium Data Set
            int[] medDataSet = DataSets.medDataSet;
            var executionTimeMed = System.Diagnostics.Stopwatch.StartNew();
            MergeSort(medDataSet);
            executionTimeMed.Stop();
          
            //Merge Sort Execution Time for Large Data Set
            int[] lrgDataSet = DataSets.lrgDataSet;
            var executionTimeLrg = System.Diagnostics.Stopwatch.StartNew();
            MergeSort(lrgDataSet);
            executionTimeLrg.Stop();
            

            //Print Results
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("###################################\n" +
                "### Merge Sort Testing Results ####\n" +
                "###### Elapsed Time in Ticks ######\n" +
                "###################################");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-5} {1,7}", "Small Data Set:", executionTimeSmall.ElapsedTicks);
            Console.WriteLine("{0,-5} {1,0}", "Medium Data Set:", executionTimeMed.ElapsedTicks);
            Console.WriteLine("{0,-5} {1,8}", "Large Data Set:", executionTimeLrg.ElapsedTicks);
            Console.ResetColor();

        }

        //Merge Sort Algorithm
        public static int[] MergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            if (array.Length <= 1)
                return array;
            int middle = array.Length / 2;
            left = new int[middle];

            if (array.Length % 2 == 0)
                right = new int[middle];
            else
                right = new int[middle + 1];

            for (int i = 0; i < middle; i++)
                left[i] = array[i];

            int j = 0;

            for (int i = middle; i < array.Length; i++)
            {
                right[j] = array[i];
                j++;
            }

            left = MergeSort(left);
            right = MergeSort(right);
            result = MergeArray(left, right);
            return result;

        }

        public static int[] MergeArray(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }

                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }

                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }

                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }










        /*
        //Quick Sort Algorithm
        public static void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSort(array, leftIndex, j);

            if (i < rightIndex)
                QuickSort(array, i, rightIndex);


        }
        */






        /*
        //Bubble Sort Algorithm
        public static void BubbleSort(int[] array)
        {
            var n = array.Length;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        var tempVar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempVar;
                    }
        */


    }
}


