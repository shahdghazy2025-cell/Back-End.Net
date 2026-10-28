using System;
class Program
{
    static void Main()
    {
        double mark;
        mark = double.Parse(Console.ReadLine());
        if (mark>=90 && mark<=100)
        {
            Console.WriteLine("Grade: Excellent");
        }
        else if (mark>=80)
        {
            Console.WriteLine("Grade: Very Good");
        }
        else if (mark>=65)
        {
            Console.WriteLine("Grade: Good");
        }
        else if (mark>=50)
        {
            Console.WriteLine("Grade: Pass");
        }
        else
        {
            Console.WriteLine("Grade: Fail");
        }
        if (mark >=50)
        {
            Console.WriteLine("Status: Passed");
        }
        else
        {
            Console.WriteLine("Status: Failed");
        }
    }
}