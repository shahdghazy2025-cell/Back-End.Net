using System;

class Program
{
    static void Main()
    {
        int age;
        double mark ;
        age = int.Parse(Console.ReadLine());
        mark = double.Parse(Console.ReadLine());
        if (mark >= 0 && mark <= 100)
        {
            double percentage = (mark / 100) * 100;
            double neededMark = 100 - mark;
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Mark: {mark}/100");
            Console.WriteLine($"Percentage: {percentage}%");
            Console.WriteLine($"Needed Mark to reach 100: {neededMark}");
        }
        else
        {
            Console.WriteLine("Invalid mark.");
        }
    }
}
