using System;

namespace Семинар_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // _____________Домашнее задание к семинару 7_______________
        

          /*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            m = 3, n = 4.
            0,5 7 -2 -0,2
            1 -3,3 8 -9,9
            8 7,8 -7,1 9*/

            /*
          Console.WriteLine("Введите колличество строк:");
          int m = int.Parse(Console.ReadLine()!);

          Console.WriteLine("Введите колличество столбцов:");
          int n = int.Parse(Console.ReadLine()!);


          double[,] Array = GetArray(m,n,0,10);
          PrintArray(Array);


           double[,] GetArray (int m, int n, int minvalue, int maxvalue){
            double[,] result = new double[m,n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   //result[i,j] = new Random().Next(minvalue,maxvalue+1); // Рандомные в пределе от мин до макс
                   result[i,j] = new Random().NextDouble()*10; // Рандомные для вещественных от 0 до 1 умноженный на 10
                } 
            }
            return result;
          }

          void PrintArray (double[,] array){
            for (int i = 0; i < array.GetLength(0); i++){
                for (int j = 0; j < array.GetLength(1); j++){
                    // Console.Write($"{array[i,j]} ");
                    Console.Write($"{Math.Round(array[i,j],1)} "); //округление массива через метод Math.Round
                }
                Console.WriteLine();
            }

          }
          */

          /*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
          и возвращает значение этого элемента или же указание, что такого элемента нет.
          Например, задан массив:
          1 4 7 2
          5 9 2 3
          8 4 2 4
          i = 4, j = 2 -> такого числа в массиве нет
          i = 1, j = 2 -> 2*/
          
          /*

          Console.WriteLine("Ваш массив:");
          int[,] YourArray = GetArray2(3,4,0,10);
          PrintArray(YourArray);
          Console.WriteLine("Запросите позицию элемента массива, строку и столбец:");

          int Str = int.Parse(Console.ReadLine()!);
          int Stlb = int.Parse(Console.ReadLine()!);

          void FindElement (int str, int stlb, int[,] array)
          {
            if (str > array.GetLength(0) || stlb > array.GetLength(1))
            {
              Console.WriteLine("Указанной позиции в элементе нет!");
            }
            else
            {
              Console.WriteLine($"Указанный элемент: {array[str-1,stlb-1]}");
            }
          }

        FindElement(Str, Stlb, YourArray);

        */

        /*   Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
        в каждом столбце.
        Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   */

        Console.WriteLine("Введите кол-во строк массива:");
        int Str = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите кол-во столбцов массива:");
        int Stlb = int.Parse(Console.ReadLine()!);
        int[,] YourArray = GetArray2(Str,Stlb,0,100);
        PrintArray(YourArray);
        GetMedian(YourArray);



        void GetMedian (int[,] array)
        {
          Console.Write("Средние числа по столбцам: ");
          for (int i = 0; i < array.GetLength(1); i++)
          {
            double result = 0;
            for (int j = 0; j < array.GetLength(0); j++)
              {
                result = result + array[j,i];
              }
             result=result/array.GetLength(1);
            Console.Write($"{result:f1} | ");
          }
        }

        int[,] GetArray2 (int m, int n, int minvalue, int maxvalue)
        {
          int[,] result = new int[m,n];
            for (int i = 0; i < m; i++)
            {
              for (int j = 0; j < n; j++)
                {
                   result[i,j] = new Random().Next(minvalue,maxvalue+1); 
                   
                } 
            }
          return result;
        }
          
        void PrintArray (int[,] array)
        {
          for (int i = 0; i < array.GetLength(0); i++){
            for (int j = 0; j < array.GetLength(1); j++){
              Console.Write($"{array[i,j]} | ");
            }
            Console.WriteLine();
          }

        }
          
          
          
          
          
          
          
          
          
          
          
        }
    }
}
