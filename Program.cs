using System;
using System.Collections.Generic;

namespace GradeBook_v3
{
    class Program
    {
        static void Main(string[] args) 
        {
            var Book1 = new Book("Scotts grade book");      //piece of state "Scotts grade book" is encapsulated inside the book object
            Book1.AddGrade(89.1);       
            Book1.AddGrade(90.5);
            Book1.AddGrade(77.5);

            var StatisticsClass = Book1.GetStats();
            //Console.WriteLine($"\nStatistics for {Book.Name}");
            Console.WriteLine($"\nThe lowest grade is {StatisticsClass.Low}");
            Console.WriteLine($"\nThe highest grade is {StatisticsClass.High}");
            Console.WriteLine($"\nThe average grade is {StatisticsClass.Average:N2}");
        }
        private static void DoAdd(string input)
        {
            throw new NotImplementedException();
        }
    }
}