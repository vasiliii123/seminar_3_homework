// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное числло");
// int num =Convert.ToInt32(Console.ReadLine());
// int num2 = (num%100)%10;
// int num3 = (num%100)/10;
// int num4 = (num2*10+num3);
// if(num/1000==num4)
// {
//     Console.WriteLine("Данное число является палиндромом");
// }
// else if(num4>99&&num4<10)
// {
//     Console.WriteLine("Вы ввели не пяти значное число");
// }
// else
// {
//     Console.WriteLine("Данное число не является палиндромом");
// }





// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z");
// int z = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координаты x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z1");
// int z1 = Convert.ToInt32(Console.ReadLine());
// double s=Math.Sqrt((Math.Pow((x1-x),2) + Math.Pow((y1-y),2)+Math.Pow((z1-z),2)));
// Console.WriteLine(s);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= num; i++)
// {
//     int num3 = i*i*i;
//     Console.WriteLine(num3);
// }
//