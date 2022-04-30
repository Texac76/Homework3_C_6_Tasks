// Задача 3. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

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
     Console.Write(Math.Pow(i,2) + ", ");
}
}

Square(N);
int result=N*N;
Console.Write(result);
