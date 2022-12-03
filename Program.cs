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
            //////////////////V1 Bubble Sort//////////////////////
            //////////////////////////////////////////////////////

            ///Note: The term Bubble Sort was first used in 1962 by Iverson and is also known as Exchange Sorting. Complexity = O(n^2) http://www.iiitdm.ac.in/old/Faculty_Teaching/Sadagopan/pdf/DAA/SortingAlgorithms.pdf

            //Bubble Sort Execution Time for Small Data Set
            int[] smallDataSet = DataSets.smallDataSet;
            var executionTimeSmall = System.Diagnostics.Stopwatch.StartNew();
            BubbleSort(smallDataSet);
            executionTimeSmall.Stop();

            //Bubble Sort Execution Time for Medium Data Set
            int[] medDataSet = DataSets.medDataSet;
            var executionTimeMed = System.Diagnostics.Stopwatch.StartNew();
            BubbleSort(medDataSet);
            executionTimeMed.Stop();

            //Bubble Sort Execution Time for Large Data Set
            int[] lrgDataSet = DataSets.lrgDataSet;
            var executionTimeLrg = System.Diagnostics.Stopwatch.StartNew();
            BubbleSort(lrgDataSet);
            executionTimeLrg.Stop();

            //Print Results
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("###################################\n" +
                "### Bubble Sort Testing Results ###\n" +
                "### Elapsed Time in Milliseconds ##\n" +
                "###################################");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-5} {1,2}", "Small Data Set:", executionTimeSmall.ElapsedMilliseconds);
            Console.WriteLine("{0,-5} {1,0}", "Medium Data Set:", executionTimeMed.ElapsedMilliseconds);
            Console.WriteLine("{0,-5} {1,4}", "Large Data Set:", executionTimeLrg.ElapsedMilliseconds);
            Console.ResetColor();

        }

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

            //Sort Success Check
            /*for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" ==> {array[i]}");
            }
            Console.WriteLine("\n");
            */

        }

    }
}

