using System;
class Program
{
   static void Main()
   {
       int department;
         Console.Write("Enter choice : ");
         department = int.Parse(Console.ReadLine());
         switch (department)
         {
             case 1:
                 Console.WriteLine("Department: Computer Science");
                 break;

                case 2:
                    Console.WriteLine("Department: Information Systems");
                    break;

                case 3:
                    Console.WriteLine("Department: Artificial Intelligence");
                    break;


                default:
                    Console.WriteLine("Invalid Department");
                    break;

    
}
   }
}