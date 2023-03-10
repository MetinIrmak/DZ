﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.WriteLine("введите количество строк");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите номер строки для элемента в двумерном массиве:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца для элемента в двумерном массиве:");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [4,4];

// FindElements(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("Элемента с такими координатами в массиве нет");
// }
// else
// {
//     Console.WriteLine($"Значение элемента с координатами: строка {n} и столбец {m} равно {numbers[n-1,m-1]}");
// }

// Console.WriteLine("Наш массив: ");
// PrintArray(numbers);

// void FindElements(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(0, 10);
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.WriteLine(""); 
//     }
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] arr = GenerationArray();
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     double result = 0;
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         result += arr[j, i];
//     }
//     result /= arr.GetLength(0);
//     Console.Write($"{result:f1}\t");
// }

// int[,] GenerationArray()
// {
//     int[,] arr = new int[3, 3];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 11);
//             Console.Write($"{arr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     return arr;
// }