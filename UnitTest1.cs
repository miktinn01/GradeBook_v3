using System;
using Xunit;    //this is a using statement to bring in the namespace
using GradeBook_v3; // add namespace ConsoleApp8 to get over error where it wasnt reading Book ... var Book1 = new Book("Scotts grade book");

namespace UnitTest_v3
{
    // below renamed from  public class UnitTest1..
    public class TestGradeBook
    {
        [Fact]  // this is an attribute attached to the following method, you can "decorate" test methods with fact attiribute to help the program find them
        public void Test1() // this is a method
        {
            // arrange

            var Book1 = new Book("");
            Book1.AddGrade(89.1);
            Book1.AddGrade(90.5);
            Book1.AddGrade(77.3);

            // act
            var result = Book1.GetStats();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
