﻿// /Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

//  int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int [size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//         for(int i = 0; i < array.Length; i++)
//         {
//             Console.Write(array[i]+ " ");
//         }
//         Console.WriteLine();
// }

// void FindMPosNegSum(int[] array)
// {
//     int sumPositiv = 0;
//     int sumNegative = 0;
//     for(int i = 0;i < array.Length;i++)
//     {
//         if(array[i] >= 0) sumPositiv+= array[i];
//         else sumNegative += array[i];
//     }
// }
//     Console.WriteLine($"Sum of positive numbers in array -> {sumPositive}, sum of negative numbers -> {sumNegative}");
//       Console.WriteLine("Input array size");
//     int size = Convert.ToInt32(Console.ReadLine());
//       Console.WriteLine("Input minimal value of array element");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//       Console.WriteLine("Input max value of array element");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     int[] myArray = CreateRandomArray(size, minValue, maxValue);
//     ShowArray(myArray);
//     FindPosNegSum(myArray);

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
// int[] array = new int[size];
// for(int i = 0;i < size; i++)
// {
// array[i] = new Random().Next(minValue, maxValue + 1);
// }
// return array;
// }

// void ShowArray (int[] array)
// {
// for(int i = 0;i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }

// int[] InvertArray (int[] array)
// {
// for(int i = 0; i < array.Length; i++)
// {
// array[i] *= (-1);
// }
// return array;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// myArray = InvertArray(myArray);
// ShowArray(myArray);


//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
// int[] array = new int[size];
// for(int i = 0;i < size; i++)
// {
// array[i] = new Random().Next(minValue, maxValue + 1);
// }
// return array;
// }

// void ShowArray (int[] array)
// {
// for(int i = 0;i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }

// bool FindNum (int[] array, int num)
// {
//     for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] == num) return true;
   
//     }
//     return false;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine(FindNum(myArray, num));

//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
// int[] array = new int[size];
// for(int i = 0;i < size; i++)
// {
// array[i] = new Random().Next(minValue, maxValue + 1);
// }
// return array;
// }
// int FindNumber (int[] array)
// {
// int kolvo = 0;
// for (int i = 0; i < array.Length; i++)
// {
// if (i >= 10 & i <= 99)
// {
// kolvo = kolvo + 1;
// }
// }
// return kolvo;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// Console.WriteLine($"В массиве значений которых лежат в отрезке [10,99] = {FindNumber(myArray)}");