using System.Diagnostics.Metrics;
using System.Reflection;

namespace Lesson2;
internal class Program
{
    static void Main(string[] args)
    {
        //        Дан двумерный массив.
        //732
        //496
        //185

        //Отсортировать данные в нем по возрастанию.
        //123
        //456
        //789

        //Вывести результат на печать.
        int[,] array = { { 7, 3, 2}, { 4, 9, 6}, { 1, 8, 5 } };
        Console.WriteLine("Исходный двумерный масив:");
        Arrayprint(array);
        int[] arr = ConvertToOneLineArray(array);
        SortArray(arr);
        array = ConvertToMatrix(arr, array.GetLength(0), array.GetLength(1));
        Console.WriteLine("Отсортированный двумерный масив:");
        Arrayprint(array);

    }
    public static void SortArray(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int n = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = n;
                }
            }
        }
    }
    public static int [] ConvertToOneLineArray(int[,] arr)
    {
        int[] res = new int[arr.Length];
        int counter = 0;
        for(int i=0; i< arr.GetLength(0); i++)
        {
            for(int j =0; j< arr.GetLength(1); j++)
            {
                res[counter] = arr[i, j];
                counter++;
            }
        }
        return res;
    }

    public static int[,] ConvertToMatrix(int[]arr, int lenth1, int lenth2)
    {
        int[,] res = new int[lenth1, lenth2];
        int counter = 0;
        for (int i = 0; i < lenth1; i++)
        {
            for (int j = 0; j < lenth2; j++)
            {
                res[i,j] = arr[counter];
                counter++;
            }
        }
        return res;
    }

    public static void Arrayprint(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"[{arr[i,j]}] ");
            }
            Console.WriteLine();
        }
    }
    
}
