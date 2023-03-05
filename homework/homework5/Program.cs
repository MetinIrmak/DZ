// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// Console.WriteLine("input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("OUR ARRAY: ");
// PrintArray(numbers);
// int count = 0;

// for (int i = 0; i < numbers.Length; i++)
// if (numbers[i] % 2 == 0)
// count++;

// Console.WriteLine($"we had {numbers.Length} numbers, {count} from them even");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int sizeArray, int start, int end)
// {
//     int[] randomArray = new int[sizeArray];
//     for (int i = 0; i < sizeArray; i++)
//     {
//         randomArray[i] = new Random().Next(start, end);
//     }
//     return randomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int SumOfElementsAttOddPosition(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }

// int[] array = CreateRandomArray(6, 0, 100);
// ShowArray(array);

// int sum = SumOfElementsAttOddPosition(array);
// Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях = {sum}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] NewArray(int len) 
// {
//     double[] array = new double[len];
// 	for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1,50);  
//     }
//     return array;
// }

// void PrintArray(double[] array)
// {
// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		System.Console.Write($"{array[i]}\t");
// 	}
// 	System.Console.WriteLine();
// }

// double[] array = NewArray(4); 
// PrintArray(array);

// double MaxNumber (double[]array)
// {
//     double max = array[0];
// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		if (max < array[i])
// 		{
// 			max = array[i];
// 		}
// 	}
// 	return max;
// }

// double MinNumber (double[]array)
// {
//     double min = array[0];
// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		if (min > array[i])
// 		{
// 			min = array[i];
// 		}
// 	}
// 	return min;
// }

// double maxNum = MaxNumber(array);
// double minNum = MinNumber(array);
// double res = maxNum-minNum;
// Console.Write($"разница между максимальным и минимальным элементов массива равна {res}");	