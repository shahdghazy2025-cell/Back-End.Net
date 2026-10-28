using System;
class Program
{
   static void Main()
   {
       for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}



string password = "rewan309";
string input = "";
int attempts = 0;

while (attempts < 3)
{
    Console.Write("Enter password: ");
    input = Console.ReadLine();
    attempts++;

    if (input == password)
    {
        Console.WriteLine("Correct password!");
        break;
    }
    else
    {
        Console.WriteLine("Wrong password!");
    }
}

for (int i = 1; i <= 20; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }

    Console.WriteLine(i);
}


   }
}
