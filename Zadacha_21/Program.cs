// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

Console.Clear();
int DataEntryXYZ(string str)
{
  Console.Write(str);
  int number = int.Parse(Console.ReadLine());
  return number;
}

double CalcDistance(int x1, int y1, int x2, int y2)
{
  double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
  return result;
}

int x1 = DataEntryXYZ("Введите координаты x1: ");
int y1 = DataEntryXYZ("Введите координаты y1: ");

int x2 = DataEntryXYZ("Введите координаты x2: ");
int y2 = DataEntryXYZ("Введите координаты y2: ");

double result = CalcDistance(x1, y1, x2, y2);
Console.WriteLine("Расстояние между точками: " + result);