using System;
using System.Collections.Generic;

namespace GradeBook_v3
{
    public class Book
    {
        // DT put (class level) variable declarations at the top, so that when you look at a class, you can straight away see what they are, rather than having them hidden away in the code.
        // DT Put blank line between methods, makes it a little less cluttered - also between different things in methods - see what I did in the CalcStats method? It's called whitespace
        // DT use of whitespace does make things more readable.  They are particularly fussy where I am now, and that is fine.

        private List<double> grades;
        //private string name;    // creates a private field name

        public Book(string name)       // requires a name when invoke constructor
        {
            grades = new List<double>();
            this.Name = name;       // this is used when the field has the same name a parameter
        }

        // DT need public property to test name
       public string Name { get; set; }

        // below creates the method AddGrade
        public void AddGrade(double grade)      //public is an access modifier, it controls access to the member of the class. 
        {
            grades.Add(grade);
        }

        public Statistics GetStats()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;        //inicialize variable to the smallest value possible
            result.Low = double.MaxValue;         //inicialize variable to the highest value possible
            //var sumOfGrades = 0.00;

            foreach (var grade in grades)       // do this for every number in the array
            {
                result.Low = Math.Min(grade, result.Low);      //returns the lowest of the 2 numbers
                result.High = Math.Max(grade, result.High);      //returns the highest of the 2 numbers
                result.Average+= grade;
            }
            result.Average /= grades.Count; // DT I'd call this ave or avg or average - call it what it is.  Is part of something called 'Clean Coding' (started by 'Uncle Bob') for when you bored and feel like googling.
            return result;
        }
    }
}