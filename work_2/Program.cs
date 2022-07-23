// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

Console.WriteLine("введите х1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите z1");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите х2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите z2");
int z2 = int.Parse(Console.ReadLine());

double Distans(int x1Loc, int y1Loc, int z1Loc, int x2Loc, int y2Loc, int z2Loc)
{
    double Dis = Math.Sqrt(Math.Pow((x2Loc - x1Loc), 2) + Math.Pow((y2Loc - y1Loc), 2) + Math.Pow((z2Loc - z1Loc), 2));
    return Dis;
}

Console.WriteLine(Distans(x1, y1, z1, x2, y2, z2));
