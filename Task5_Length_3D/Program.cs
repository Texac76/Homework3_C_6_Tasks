// Задача 5.Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int GetValue(string text)
{
    Console.Write($"{text} ");
string GetValueStr=Console.ReadLine()!;
int value=Convert.ToInt32(GetValueStr);
return value;
}

double Pifagor(int ax, int ay, int az, int bx, int by, int bz)
{

    return Math.Sqrt(Math.Pow(bx-ax,2)+ Math.Pow(by-ay,2)+Math.Pow(bz-az,2));
}

int Ax=GetValue("Ax= ");
int Ay=GetValue("Ay= ");
int Az=GetValue("Az= ");
int Bx=GetValue("Bx= ");
int By=GetValue("By= ");
int Bz=GetValue("Bz= ");

double result= Pifagor(Ax, Ay, Az, Bx, By, Bz);
Console.WriteLine(Math.Round(result,2));