// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Deletedecimal (int num)
// {
//     int sot = num % 100;
//     return sot / 10;
// }
// Console.WriteLine("Input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Deletedecimal(num));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.Write("Введите любое число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2)
// {
//   Console.WriteLine($"Третья цифра в числе {anyNumber} - " + anyNumberText[2]);
// }
// else
//  {
//   Console.WriteLine($"Третьей цифры в числе {anyNumber} - нет");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("введите число от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine());
// {
//     if (num > 0 && num < 6)
//     {
//     Console.WriteLine($"Нет. День {num} выходным не является");
//     }
//     else if (num > 5 && num < 8)
//     {
//     Console.WriteLine($"Да. День {num} является выходным");
//     }
//     else
//     {
//     Console.WriteLine($"Ошибка! Неправильно введенное число, введите число от 1 до 7!");
//     }
// }