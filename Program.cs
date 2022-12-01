// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("give me a number n");
// int n = Convert.ToInt32(Console.ReadLine());

// string Number(int start, int end){
//     if(end == start){
//         return start.ToString();
//     }  
//     return(end+" "+Number(start,end - 1));
// }
// Console.WriteLine(Number(1,n));




// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("give me a number n");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number n");
// int n = Convert.ToInt32(Console.ReadLine());

// int Number(int m, int n){
//     if(m == n){
//         return m;
//     }  
//     return(m+Number(m+1,n));
// }
// Console.WriteLine(Number(m,n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("give me a number n");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number n");
// int n = Convert.ToInt32(Console.ReadLine());

// int Number(int m, int n){
//     if(m == 0){
//         return n+1;
//     }if(m != 0 && n == 0){
//         return (Number(m-1,1)); 
//     }if(m > 0 && n > 0){
//         return (Number(m-1,Number(m,n-1))); 
//     }
//     return (Number(m,n));

// }
// Console.WriteLine(Number(m,n));

// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("give me a number n");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("give me a number n");
// int n = Convert.ToInt32(Console.ReadLine());

// string Number(int start,int end){
//     if(end < start){
//         return "no correct";
//     }if(end == start){
//         return start.ToString();
//     }      
//     return(start+" "+Number(start+1,end));
// }
// Console.WriteLine(Number(m, n));


// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("give me a number n");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("give me a number n");
// int n = Convert.ToInt32(Console.ReadLine());

// int Number(int m,int n){

//     if(n==0){
//         return 1;
//     }
//     if(n==1){
//     return m;
//     }       
//     return(m* Number(m,n-1));
// }
// Console.WriteLine(Number(m,n));