
// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("give me a number");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите диапазон случайных чисел: от 1 до ");
// int range = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int[rows,columns];
// CreateArray(array);
// WriteArray(array);

// Console.WriteLine($"\nОтсортированный массив: ");
// Change(array);
// WriteArray(array);

// void Change(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for (int j = 1; j < matrix.GetLength(0); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if(matrix[i,k]<matrix[i,k+1])
//             {
//                 int temp= matrix[i,k+1];
//                 matrix[i,k+1] = matrix[i,k];
//                 matrix[i,k] = temp;
//             }
//             }
//         }
//     }
// }


// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + "\t");
//     }
//     Console.WriteLine();
//   }
// }



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("give me a number");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите диапазон случайных чисел: от 1 до ");
// int range = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, columns];
// CreateArray(array);
// WriteArray(array);

// int index = 0;
// int sumLine = SumLineElements(array,0);
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int tempSumLine = SumLineElements(array,i);
//     if(sumLine>tempSumLine){
//         sumLine=tempSumLine;
//         index = i;
//     }
// }
// Console.WriteLine($"\n{index+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

// int SumLineElements(int [,] matrix, int i)
// {
//     int sumLine = matrix[i,0];
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sumLine += matrix[i,j];
//     }
//     return sumLine;
// }


// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + "\t");
//     }
//     Console.WriteLine();
//   }
// }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет
//  находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.WriteLine("give me a number to rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number to columns");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("give me a number to rows");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number to columns");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите диапазон случайных чисел: от 1 до ");
// int range = Convert.ToInt32(Console.ReadLine());

// int [,] firstMatrix = new int[rows,columns];
// CreateArray(firstMatrix);
// Console.WriteLine("1 matrix");
// WriteArray(firstMatrix);

// int [,] secondMatrix = new int[rows1,columns1];
// CreateArray(secondMatrix);
// Console.WriteLine("2 matrix");
// WriteArray(secondMatrix);

// int[,] resultMatrix = new int[rows,columns1];

// MultiMatrix(firstMatrix,secondMatrix,resultMatrix);
// Console.WriteLine($"\nПроизведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiMatrix(int [,] firstMatrix, int [,] secondMatrix, int[,] resultMatrix)
// {
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < firstMatrix.GetLength(1); k++)
//             {
//                 sum += firstMatrix[i,k] * secondMatrix[k,j];
//             }
//             resultMatrix[i,j] = sum;
//         }
//     }
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + "\t");
//     }
//     Console.WriteLine();
//   }
// }



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("give me a number 1");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number 2");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number 3 ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите диапазон случайных чисел: от 1 до ");
// int range = Convert.ToInt32(Console.ReadLine());

// int [,,] array = new int[rows,columns,n];
// CreateArray(array);
// WriteArray(array);





// void CreateArray(int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             array[i, j, k] = new Random().Next(range);
//         }
//     }
//   }
// }

// void WriteArray (int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             Console.Write(array[i,j,k] + "\t");
//         }
//     }
//     Console.WriteLine();
//   }
// }
// мы не проходили трехмерные массивы, поэтому перерыв интернет я могу тупо скопировать вам это решение, но какой в этом смысл(

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




// С прошлого дз понимаю, что как будто потеряла нить понимания , как только начались методы резко,
//  может у вас есть какие-то доп задания, с 6-8 семинар, что бы я более плавно пришла к пониманию?










