// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int numA;
bool res = int.TryParse(number, out numA);
if (res == true)
//int number = Convert.ToInt32(Console.ReadLine());
   for (int i=1; i<=numA; i++)
       Console.WriteLine(i*i*i);
else
Console.WriteLine("Это не число");       
