﻿
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.WriteLine("give me a number");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(-9, 10) + new Random().NextDouble();
//         array[i,j] = Math.Round(array[i,j], 1);
//         Console.Write(array[i,j]+ "\t");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в
//  двумерном массиве, и возвращает значение этого элемента или 
//  же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.WriteLine("give me a number");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];


// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j]= new Random().Next(11);
//         Console.Write(array[i,j]+"\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("введите координаты");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координаты");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a>m&&b>n){
//      Console.WriteLine("такого числа нет");
// }else{
//     Console.WriteLine($"ваше число {array[a,b]}");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите
//  среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.WriteLine("give me a number");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(10);
//         Console.Write(array[i,j]+ "\t");
//     }
//     Console.WriteLine();
// }

// double[] sum = new double[array.GetLength(1)];
// for (int j = 0; j < array.GetLength(1); j++)
// {   
//     sum[j] = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum[j]+=array[i,j];
//     }
//     Console.WriteLine($"{j} среднее арифметическое {sum[j]/m}");
// }