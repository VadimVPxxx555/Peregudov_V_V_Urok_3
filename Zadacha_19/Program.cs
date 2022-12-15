// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли 
// оно палиндромом.
Console.Clear();
int DataNumber(string str)
{
   Console.Write(str);
   int number = int.Parse(Console.ReadLine());
   return number;
}
void Palindrom(int x)
{
   char[] array = x.ToString().ToCharArray();
   int size = array.Length;
   int i = 1;
   int numb = x;
   int numbA = 0;
   int numbB = 0;

   while(i <= size)
   {
      numbA = numb % 10;
      numbB = numbA + numbB;
      numbB = numbB * 10;
      numb = numb / 10;
      i++;
   }
   numbB = numbB / 10;
   Console.WriteLine(numbB);
   //Console.WriteLine(numb);

   if(x == numbB)
   {
     Console.WriteLine(x + " -> да"); 
   }
  else
  {
     Console.WriteLine(x + " -> нет");
  } 
}

int x = DataNumber("введите пятизначное число ");

Palindrom(x);