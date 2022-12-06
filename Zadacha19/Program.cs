// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;
int numA;
bool res = int.TryParse(number, out numA);
if (res == true)
    if (len == 5)
       
        if (number[0] == number[4] && number[1] == number[3])
           {
            Console.WriteLine("Палиндром");
           }
        else
           {
            Console.WriteLine("Не палиндром");
           }
        
    else
       {
        Console.WriteLine("Не пятизначное число");
       }
else
    Console.WriteLine("Не является числом");      
