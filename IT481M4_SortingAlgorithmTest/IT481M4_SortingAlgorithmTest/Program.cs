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
            ///////////////////V2 Quick Sort//////////////////////
            //////////////////////////////////////////////////////

            ///Note: Quick Sort was created by Tony Hoare in 1959 as a divide and conquer sorting method with an average complexity of O(n log(n)) https://dev.to/snj/quicksort-the-history-and-implementations-28o2

            //Quick Sort Execution Time for Small Data Set
            int[] smallDataSet = DataSets.smallDataSet;
            int leftIndexSmall = 0;
            int rightIndexSmall = smallDataSet.Length - 1;
            var executionTimeSmall = System.Diagnostics.Stopwatch.StartNew();
            QuickSort(smallDataSet, leftIndexSmall, rightIndexSmall);
            executionTimeSmall.Stop();

            //Quick Sort Execution Time for Medium Data Set
            int[] medDataSet = DataSets.medDataSet;
            int leftIndexMed = 0;
            int rightIndexMed = medDataSet.Length - 1;
            var executionTimeMed = System.Diagnostics.Stopwatch.StartNew();
            QuickSort(medDataSet, leftIndexMed, rightIndexMed);
            executionTimeMed.Stop();

            //Quick Sort Execution Time for Large Data Set
            int[] lrgDataSet = DataSets.lrgDataSet;
            int leftIndexLrg = 0;
            int rightIndexLrg = lrgDataSet.Length - 1;
            var executionTimeLrg = System.Diagnostics.Stopwatch.StartNew();
            QuickSort(lrgDataSet, leftIndexLrg, rightIndexLrg);
            executionTimeLrg.Stop();

            //Print Results
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("###################################\n" +
                "### Quick Sort Testing Results ###\n" +
                "###### Elapsed Time in Ticks ######\n" +
                "###################################");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-5} {1,7}", "Small Data Set:", executionTimeSmall.ElapsedTicks);
            Console.WriteLine("{0,-5} {1,0}", "Medium Data Set:", executionTimeMed.ElapsedTicks);
            Console.WriteLine("{0,-5} {1,8}", "Large Data Set:", executionTimeLrg.ElapsedTicks);
            Console.ResetColor();

            /*
            //Sort Success Check
            for (int i = 0; i < medDataSet.Length; i++)
            {
                Console.Write($" ==> {medDataSet[i]}");
            }
            Console.WriteLine("\n");
            */

        }



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


