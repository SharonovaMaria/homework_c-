//Задача 26: Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
//89126 -> 5

// Console.WriteLine("Введите число"); //456
// string num = Console.ReadLine(); 

// int CountNum(string number){
//     int n = number.Length;
//     return n;
// }
// Console.WriteLine(CountNum(num));


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите число"); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число"); 
// int b = Convert.ToInt32(Console.ReadLine()); 

// int Func(int a, int b){
//     int result=1;
//     for(int i =0; i<b;i++){
//         result*=a;
//     }
//     return result;
// }
// Console.WriteLine(Func(a,b));

// Задача 27: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.WriteLine("Введите число"); 
// int a = Convert.ToInt32(Console.ReadLine()); 

// int Func(int num){
//     int length = Convert.ToString(a).Length;
//     int b =0;
//     int result= 0;
//     for(int i=0;i<length;i++){
//         b = num - num%10;
//         result = result + (num - b);
//         num = num / 10;
//     }
//     return result;
// }
// Console.WriteLine(Func(a));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = GetArray(8);
int[] GetArray(int size){
    int[] array = new int[size];

    for(int i =0;i<size;i++){
        array[i]= new Random().Next(0,100);

    }
    return array;
}
Console.WriteLine(String.Join(',',array));