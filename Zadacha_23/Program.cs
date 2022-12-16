// Напишите программу, которая принимает на вход
// число (N) и выдает таблицу кубов чисел от 1 до N.

Console.Clear();
void TablePOW3(string str)
{
  Console.Write(str);
  int number = int.Parse(Console.ReadLine());
  int count = 1;
  while (count <= number)
  {
    double pow = Math.Pow(count, 3);
    Console.Write(pow + " ");
    count++;
  }
  Console.WriteLine();
}

TablePOW3("Введите число ");