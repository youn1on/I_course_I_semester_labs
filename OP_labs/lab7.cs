using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int minimumIndex = 0;
            double[] array = new double[n];
            FillArray(array);
            GetMinValue(array, ref minimumIndex);
            Sort(array, minimumIndex);
        }

        static void FillArray(double[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(rand.Next(-100, 101) + rand.NextDouble(),2);
            }
        }

        static double GetMinValue(double[] array, ref int minimumIndex)
        {
            double minValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minimumIndex = i;
                }
            }
            return minValue;
        }

        static void Sort(double[] array, int minimumIndex)
        {
            double tmp;
            for (int j = 0; j < array.Length ; j++)
            { 
                for (int i = 0; i < minimumIndex; i++)
                {
                    if (array[i + 1] > array[i])
                    {
                        tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
            }
        }
    }
}