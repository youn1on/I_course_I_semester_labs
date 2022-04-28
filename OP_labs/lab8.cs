using System;
using System.Collections.Generic;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] matrix;
            List<int> saddlePoints;
            n = Convert.ToInt32(Console.ReadLine());
            matrix = GenerateSquareMatrix(n);
            saddlePoints = GetSaddlePoints(matrix);
            DisplaySaddlePoints(matrix, saddlePoints);
        }

        static int[,] GenerateSquareMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            Random rand = new Random();
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }
            return matrix;
        }

        static bool IsMinRowValue(int[,] matrix, int rowIndex, int value)
        {
            int minValue = matrix[0, rowIndex];
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, rowIndex] < minValue)
                {
                    minValue = matrix[i, rowIndex];
                }
            }
            return value == minValue;
        }

        static bool IsMaxColumnValue(int[,] matrix, int columnIndex, int value)
        {
            int maxValue = matrix[columnIndex, 0];
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[columnIndex, j] > maxValue)
                {
                    maxValue = matrix[columnIndex, j];
                }
            }
            return value == maxValue;
        }

        static List<int> GetSaddlePoints(int[,] matrix)
        {
            List<int> saddlePoints = new List<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (IsMinRowValue(matrix, j, matrix[i, j]) && IsMaxColumnValue(matrix, i, matrix[i, j]))
                    {
                        saddlePoints.Add(matrix[i, j]);
                    }
                }
            }
            return saddlePoints;
        } 
        
        static int[] GetIndex(int[,] matrix, int value)
        {
            int[] index = new int[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == value)
                    {
                        index[0] = j+1;
                        index[1] = i+1;
                    }
                }
            }
            return index;
        }

        static void DisplaySaddlePoints(int[,] matrix, List<int> saddlePoints)
        {
            int[] index;
            if (saddlePoints.Count == 0)
            {
                Console.WriteLine("No saddle points found. ");
            }
            else
            {
                for (int i = 0; i < saddlePoints.Count; i++)
                {
                    index = GetIndex(matrix, saddlePoints[i]);
                    Console.WriteLine($"Saddle point {saddlePoints[i]} position ({index[0]},{index[1]}) ");
                }
            }
        }
    }
}
