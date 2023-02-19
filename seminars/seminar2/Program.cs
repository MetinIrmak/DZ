// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

// void MaxDecimal (int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if(ed>dec)
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {ed}");
//     }
//     else
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {dec}");
//     }
// }

// int num = new Random().Next(10, 99 + 1);

// MaxDecimal(num);

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int Deletedecimal (int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot*10 + ed;
// }

// int randomnumber = new Random().Next(100, 1000);
// Console.WriteLine(randomnumber);
// // int result = Deletedecimal(randomnumber);
// // Console.WriteLine(result);
// Console.WriteLine(Deletedecimal(randomnumber));

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// void Devid723Decimal(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//     Console.WriteLine ("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());

// Devid723Decimal(num);

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void KratDecimal(double num1, double num2)
// {
//     if (num1 % num2 == 0)
//     {
//     Console.WriteLine("Кратно");    
//     }
//     else
//     {
//     Console.WriteLine($"Остаток от деления {num1} / {num2} = {num1 % num2}");
//     } 
// }
// Console.WriteLine("Input firstnumber");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input secondnumber");
// double num2 = Convert.ToDouble(Console.ReadLine());

// KratDecimal(num1, num2);