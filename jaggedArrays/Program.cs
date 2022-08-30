using System;

namespace jaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 33, 5, 776, 9989 };

            //declaring jaggedArray
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 2, 3, 5, 4, 6 };
            jaggedArray[1] = new int[] { 21, 61, 12 };
            jaggedArray[2] = new int[] { 121, 261 };
            jaggedArray[3] = numbers; //we can add array like this

            //alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int [] { 2,3,5,4,6 },
                new int [] { 21,61,12},
                new int [] { 121,261}
            };
            //accessing single 
            Console.WriteLine(jaggedArray2[1][1]);


            //writing all into the console
            foreach (Array arr in jaggedArray)
            {
                foreach (int entry in arr)
                {
                    Console.Write(" " + entry);
                }

            }
            GetAverage(jaggedArray);

            Console.ReadKey();

            // arrays as parameter

            static void GetAverage(Array[] jaggedArray)
            {
                int size = 0;
                double average = 0;
                int sum = 0;

                foreach (Array arr in jaggedArray)
                {
                    foreach (int entry in arr)
                    {
                        size++;
                        sum = +entry;
                    }
                }
                average = (double)sum / size;
                Console.WriteLine("\n");
                Console.WriteLine("size: {0}, sum: {1}, average: {2}", size, sum, average);

            }
        }
    }
}
