
/********

**

** Name: Zhang, Qinglong

** Class: IS 375

** Project: PE01

** Date: 2020-04-12

** Description: Write an application that creates a two-dimensional array.
* Allow the user to input the size of the array (number of rows and number of columns).
* Fill the array with random numbers between 0 and 100. Search the array for the largest value.
* Display the array values, numbers aligned, and the indexes where the largest value is stored..

** Include those aspects that would be relevant for someone

** viewing the project without any prior information about the project.

**

********/
using System;

namespace week1MultidimensionalArrayProgram
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int row, column, largeValueIndex;
            int[,] twoDimensionalArray;
            Random rnd = new Random();
            GetSizeOfArray(out row, out column);
            twoDimensionalArray = new int[row, column];
            FillArray(twoDimensionalArray);
            DisplayTable(twoDimensionalArray);
            DisplayLargestValue(twoDimensionalArray);
            largeValueIndex = FindLargestValue(twoDimensionalArray, ref row, ref column);
            Console.WriteLine("Largest value's index is : " + row + ", " + column);
        }
        public static void GetSizeOfArray(out int rowsize, out int columnsize)
        {
            Console.WriteLine(" Enter the row size of your two dimensional array:");
            rowsize = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the Column size of your two dimensional array:");
            columnsize = int.Parse(Console.ReadLine());
        }
        public static void FillArray(int[,] ranArray)
        {
            Random randomFill = new Random();
            for (int i = 0; i < ranArray.GetLength(0); i++)
            {
                for (int j = 0; j < ranArray.GetLength(1); j++)
                {
                    ranArray[i, j] = randomFill.Next(0, 100);
                }
            }
        }
        public static void DisplayTable(int[,] ranArray)
        {
            for (int i = 0; i < ranArray.GetLength(0); i++)
            {
                for (int j = 0; j < ranArray.GetLength(1); j++)
                {
                    Console.Write(ranArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void DisplayLargestValue(int[,] ranArray)
        {
            int max = int.MinValue;
            int maxX = -1;
            int maxY = -1;
            for (int x = 0; x < ranArray.GetLength(0); x++)
            {
                for (int y = 0; y < ranArray.GetLength(1); y++)
                {
                    if (ranArray[x, y] > max)
                    {
                        max = ranArray[x, y];
                        maxX = x;
                        maxY = y;
                    }
                }
            }
            Console.WriteLine("Largest value is : " + max);
        }
        public static int FindLargestValue(int[,] ranArray, ref int smallRow, ref int smallCol)
        {
            int max = int.MinValue;
            for (int x = 0; x < ranArray.GetLength(0); x++)
            {
                for (int y = 0; y < ranArray.GetLength(1); y++)
                {
                    if (ranArray[x, y] > max)
                    {
                        max = ranArray[x, y];
                        smallRow = x;
                        smallCol = y;
                    }
                }
            }
            return max;
        }
    }
}
