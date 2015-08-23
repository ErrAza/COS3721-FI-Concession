//Author: Sean McCann
//Student Number: 49460951
//Subject: COS3721 

using System;
using System.Linq;
using System.Threading;

namespace ThreadProgCsharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int size = 10;
            var mainList = new int[size];
            PopulateArray(mainList, size);
            Console.WriteLine("Proceed? (y/n)");
            if (Console.ReadLine() == "y")
            {
                var leftArray = SplitArrayFirstHalf(mainList);
                Console.WriteLine("Proceed to Second Array Split? (y/n)");
                if (Console.ReadLine() == "y")
                {
                    var rightArray = SplitArraySecondHalf(mainList);
                    Console.WriteLine("Proceed to Threaded Sorting? (y/n)");
                    if (Console.ReadLine() == "y")
                    {
                        Threading(leftArray, rightArray);
                    }
                }
            }
            else Environment.Exit(1);
        }

        public static int[] PopulateArray(int[] array, int size)
        {
            Console.WriteLine("Populating Array of Size: " + size);

            var rnd = new Random();

            for (var i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.WriteLine(array[i]);
            }

            return array;
        }

        public static void Threading(int[] leftArray, int[] rightArray)
        {
            var thread1 = new Thread(ArraySort);
            var thread2 = new Thread(ArraySort);

            thread1.Start(leftArray);
            thread2.Start(rightArray);

            Console.WriteLine("Threading Complete: Arrays Sorted");

            Console.WriteLine("Proceed? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Left Array");
                for (var i = 0; i < leftArray.Length; i++)
                {
                    Console.WriteLine(leftArray[i]);
                }

                Console.WriteLine("Right Array");
                for (var i = 0; i < rightArray.Length; i++)
                {
                    Console.WriteLine(rightArray[i]);
                }
            }

            Console.WriteLine("Merging Arrays for Sort...");

            var mergeThread = new Thread(unused => MergeSortArrays(leftArray, rightArray));

            mergeThread.Start();
        }

        public static void MergeSortArrays(Object left, Object right)
        {
            var leftArray = (int[]) left;
            var rightArray = (int[]) right;

            var totalSize = leftArray.Length + rightArray.Length;

            Console.WriteLine("Final Array Size: " + totalSize);

            var result = leftArray.Concat(rightArray).ToArray();

            Console.WriteLine("Array Merged...");

            Array.Sort(result);

            Console.WriteLine("Array Sorted, Final Array is: ");

            for (var i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.WriteLine("Finished. Press Enter To Exit");
            Console.ReadLine();
        }

        public static void ArraySort(Object data)
        {
            var x = 0;

            var insertedArray = (int[]) data;

            Array.Sort(insertedArray);
        }

        public static int[] SplitArrayFirstHalf(int[] array)
        {
            Console.WriteLine("Splitting into First Half");
            var leftArray = new int[array.Length/2];

            for (var i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = array[i];
                Console.WriteLine(leftArray[i]);
            }
            return leftArray;
        }

        public static int[] SplitArraySecondHalf(int[] array)
        {
            Console.WriteLine("Splitting into Second Half");
            var rightArray = new int[array.Length/2];
            var counter = 0;

            for (var i = rightArray.Length; i < array.Length; i++)
            {
                rightArray[counter] = array[i];
                Console.WriteLine(rightArray[counter]);
                counter++;
            }
            return rightArray;
        }
    }
}