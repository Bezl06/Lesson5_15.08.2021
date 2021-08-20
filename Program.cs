using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2
            System.Console.Write("Введите размер вашего массива : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = GetRandomArr(size);
            System.Console.WriteLine("Значения вашего масиива : ");
            foreach (var item in arr)
                System.Console.Write($"{item} ");
            System.Console.WriteLine();
            int min = int.MaxValue, max = int.MinValue, summ = 0;
            for (int i = 0; i < size; summ += arr[i], i++)
            {
                min = arr[i] < min ? arr[i] : min;
                max = arr[i] > max ? arr[i] : max;
                if (arr[i] % 2 == 1) System.Console.WriteLine($"Нечетное значение : {arr[i]}");
            }
            System.Console.WriteLine($"Наибольшое значение массива : {max}");
            System.Console.WriteLine($"Наименьшее значение массива : {min}");
            System.Console.WriteLine($"Общая сумма всех элементов : {summ}");
            System.Console.WriteLine($"Среднее арифметическое всех элементов : {(double)summ / (double)size}");

            //Задача 3
            System.Console.Write("\nВведите размер вашего массива : ");
            size = int.Parse(Console.ReadLine());
            arr = GetRandomArr(size);
            int[] arrRev = new int[size];
            System.Console.WriteLine("Значения вашего масиива : ");
            for (int i = 0, t = size; i < size; i++)
            {
                System.Console.Write($"{arr[i]} ");
                arrRev[--t] = arr[i];
            }
            System.Console.WriteLine("\nЗначения вашего масиива теперь : ");
            arr = arrRev;
            foreach (var item in arr)
                System.Console.Write($"{item} ");

            //Задача 4
            System.Console.Write("\n\nВведите размер вашего массива : ");
            size = int.Parse(Console.ReadLine());
            arr = GetRandomArr(size);
            System.Console.WriteLine("Значения вашего масиива : ");
            foreach (var item in arr)
                System.Console.Write($"{item} ");
            System.Console.WriteLine("\nВведите значения переменных \"count\" и \"index\" :");
            int count = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            int[] arrCount = new int[count];
            for (int i = 0; i < count; i++)
                arrCount[i] = index < size ? arr[index++] : 1;
            System.Console.WriteLine("Значения вашего нового масиива размера \"count\" :");
            foreach (var item in arrCount)
                System.Console.Write($"{item} ");
        }
        static int[] GetRandomArr(int size)
        {
            Random rd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rd.Next(0, 100);
            return arr;
        }
    }
}
