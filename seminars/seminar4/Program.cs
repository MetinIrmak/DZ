﻿//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36

// int FindSum(int a)
// {
//     int sum = 0;
//     for(int current= 1;current<=a;current++)
//     {
//         sum = sum + current;// sum+=current;
//     }
//     return sum;
// }

// Console.WriteLine("Input A");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindSum(a));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
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

//     Console.WriteLine("Input array size");
//     int size = Convert.ToInt32(Console.ReadLine());
//       Console.WriteLine("Input minimal value of array element");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//       Console.WriteLine("Input max value of array element");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[] myArray = CreateRandomArray(size, minValue, maxValue);
    
//     ShowArray(myArray);

// ЗАДАНИЕ №2. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

// 456 - 3
// 78 - 2

// int CountNumber(int num)
// {
// int count = 0;
// while (count < num)
// {
// num /= 10;
// count++;

// }
// return count;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountNumber(num));

//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4 -> 24
//5 -> 120

int Factor(int num)
{

int n = 1;
for (int i = 1; i <= num; i++)
{

n = n * i;

}
return n;

}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factor(num));