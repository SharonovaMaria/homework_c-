// Задача 19

// Напишите программу, которая принимает на вход пятизначное
//  число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// Console.WriteLine("Введите число"); //12321
// string num = (Console.ReadLine()); 
// int length = num.Length;

// if(length == 5){
//     if(num[0]== num[4]&&num[1]==num[3]){
//         Console.WriteLine("Это палиндром!");
//     }else{
//         Console.WriteLine("Это не палиндром!");
//     }
// }else{
//     Console.WriteLine("Введите пятизначное число!");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите число"); 
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число"); 
// int y1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число"); 
// int z1 = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Введите число"); 
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число"); 
// int y2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число"); 
// int z2 = Convert.ToInt32(Console.ReadLine()); 

// double dis = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

// Console.WriteLine(dis); 

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число"); 
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i<=num;i++){
    Console.WriteLine(Math.Pow(i,3)); 
}