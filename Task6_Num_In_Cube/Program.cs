// Задача 6. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int GetValue(string text)
{
Console.Write($"{text} ");
string GetValueStr=Console.ReadLine()!;
int value=Convert.ToInt32(GetValueStr);
return value;
}

int N=GetValue("N= ");

void Square(int value)
{
for (int i = 1; i < value; i++)
{
     Console.Write(Math.Pow(i,3) + ", ");
}
}

Square(N);
int result=N*N*N;
Console.Write(result);