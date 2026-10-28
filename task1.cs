using System;

class Program
{
    static void Main()
    {
        string name;
        int age;
        double mark;
        const double MaxMark = 100.0;
        Console.Write("===== Student Grade Management System =====");


        Console.Write("Enter student's name: ");
        name = Console.ReadLine();
        Console.Write("Enter student's age: ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Enter student's mark: ");
        mark = double.Parse(Console.ReadLine());
        Console.WriteLine($"Welcome, {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mark: {mark}");
        Console.WriteLine($"Maximum Mark: {MaxMark}");
    }
}