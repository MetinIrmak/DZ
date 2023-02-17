// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     Console.WriteLine("First number is higher then second number");
// }
// if (num1 < num2)
// {
//     Console.WriteLine("Second number is  higher then First number");
// }

// Задача 4 . Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2 && num1 > num3) 
// {
//     Console.WriteLine($"Max number is {num1}");
// }
// else
// if (num2 > num3)
// {
//  Console.WriteLine($"Max number is {num2}");
//  }
//  else 
//  {
//  Console.WriteLine($"Max number is {num3}");
// }

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0) 
// {
//     Console.WriteLine($"ДА. Число {num} делится на два без остатка");
// }
// else
// {
//  Console.WriteLine($"NO. Число {num} делится на два c остатком");
//  }

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 2;

// if(num > 1)
// {
//     while(evenNumber <= num)
//     {
//         Console.Write(evenNumber + " ");
//         evenNumber = evenNumber + 2;
//     }
// }