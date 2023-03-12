// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// int DegreeNumber (int num1, int num2)
// {
//     int deg = 1;
//     for(int count = 0; count < num2; count++)
//     {
//         deg = num1*deg;
//     }
//     return deg;
// }

// Console.WriteLine ("Input num1:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input num2:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ($"Degeree {num1}^{num2} -> {DegreeNumber (num1, num2)}");



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int SummNum(int num)
// {
//     int num2 =0;
//     int sum = 0;
//     {
//         for(num2 = num; num!=0; num = num / 10 )
//         {
//         num2 = num % 10;
//         sum = sum + num2;
//         }
//     }
//     return sum;
// }

// Console.WriteLine ("Input num1:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SummNum(num));


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(size, minValue, maxValue));