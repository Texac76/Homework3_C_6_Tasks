// 4. Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// int N=12821; // Короткое решение
// if (Math.Abs(N/1000-N%100)==9 || Math.Abs(b-a)==0)
// {
// Console.Write("да");
// }
// else
// {
// Console.Write("нет");
// }

Console.Clear();

int GetValue(string text)
{
Console.Write($"{text} ");
string GetValueStr=Console.ReadLine()!;
int value=Convert.ToInt32(GetValueStr);
return value;
}

int N=GetValue("N= ");               // Вводим 12821

void function(int n)
{
int a = n/1000; 
int b=N%100;                      // Находим остаток от деления 12821 на 100, b = 21


if(Math.Abs(b-a)==9 || Math.Abs(b-a)==0)                 // 12321 --> 21-12=9 и если левая чать числа больше правой 21212 --> |12-21|=9
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}
}
function(N);
