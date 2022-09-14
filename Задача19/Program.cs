//Задача 19
//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
    {
         int x = number / 10000;
         int y = number % 10; 
         int x2 = number / 100;
         int y2 = number % 10;
    
            if(x == y ||x2 == y2)
            {
                    Console.WriteLine("палиндром");
            }
            else 
            Console.WriteLine("Нет");
            }
            


