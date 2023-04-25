// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.Write("Введите число А: ");
// string strA = Console.ReadLine();
// int A = Convert.ToInt32(strA);
// Console.Write("Введите число B: ");
// string strB = Console.ReadLine();
// int B = Convert.ToInt32(strB);
// double C = Math.Pow(A,B);
// Console.Write("Число А в степени B равно: ");
// Console.WriteLine(C);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.Write("введите число: ");
// string str = Console.ReadLine();
// int lenght = str.Length;
// int i = 0;
// int sum = 0;
// int b = 0;
// int a = Convert.ToInt32(str);
// int[] array = new int[lenght];
// while (i<lenght-1)
// {
//     b = a%10;
//     array[i] = b;
//     a = a/10;
//     i++;
// }
// array[lenght-1] = a;
// i = 0;
// while(i<lenght)
// {
//     sum = sum + array[i];
//     i++;
// }
// Console.Write("Сумма цифр в числе равна: ");
// Console.WriteLine(sum);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов (от -10 до 10) и выводит их на экран.
// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]
// 6, 1, 3 -> [6, 1, 3]
// int index = 0;
// int [] array = new int[8];
// while (index<array.Length)
// {
//     array[index] = new Random().Next(-10,11);
//     Console.Write(array[index]);
//     Console.Write(", ");
//     index++;
// }

