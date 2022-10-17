// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число"); 
// int number_1 = Convert.ToInt32(Console.ReadLine()); 

// if(number_1%2 == 0){
//     Console.WriteLine("да");
// }else{
//     Console.WriteLine("нет");
// }

// Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число"); 
// int number_1 = Convert.ToInt32(Console.ReadLine()); 
// for(int number_2 = 1; number_2 <= number_1; number_2++){
//         if(number_2%2 == 0){
//         Console.WriteLine(number_2);
//         }
// }
// Напишите программу, которая принимает на вход три числа и
//  выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// Console.WriteLine("Введите число"); 
// int number_1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число"); 
// int number_2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число"); 
// int number_3 = Convert.ToInt32(Console.ReadLine()); 

// int max = 0;

// if(number_1>number_2&number_1>number_3 ){
//         max = number_1;
// }else if(number_2>number_1&number_2>number_3 ){
//         max = number_2;
// }else{
//         max = number_3;
// }
// Console.WriteLine(max);

// или так

// int max = number_1;

// if(number_2>max){
//         max = number_2;
// }else if(number_3>max){
//         max = number_3;
// }
// Console.WriteLine(max);

//  Напишите программу, которая на вход принимает два числа и выдаёт,
//   какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число"); 
int number_1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число"); 
int number_2 = Convert.ToInt32(Console.ReadLine()); 

int max = number_1;
int min = number_2;

if(number_2>max){
        max = number_2;
        min = number_1;
}
Console.WriteLine("max = " + max + "\n" + "min = " + min);
