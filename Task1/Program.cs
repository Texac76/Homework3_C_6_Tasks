
//1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());

Console.Clear();

int GetValue(string text)
{
    Console.Write($"{text}: ");
string GetValueStr=Console.ReadLine()!;
int value=Convert.ToInt32(GetValueStr);
return value;
}

int x=GetValue("Введите x");
int y=GetValue("Введите y");


if (x>0 & y>0)
 {
    Console.WriteLine(" 1 " );
 }

    else if (x>0 & y<0)
    {
        Console.WriteLine(" 2 " );
    }

    else if (x<0 & y<0)
    {
        Console.WriteLine(" 3 " );
    }
else
{
    Console.WriteLine(" 4 " );
}
