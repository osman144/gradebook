using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade_AssertEqual()
        {
          // Arrange
          var book = new Book("");
          book.AddGrade(89.1);
          book.AddGrade(90.5);
          book.AddGrade(77.5);


          // Act 
          var result = book.GetStats();

          Console.WriteLine($"Max = {result.High}");
          Console.WriteLine($"Min = {result.Low}");
          Console.WriteLine($"Average = {result.Average:N3}");
          Console.WriteLine($"Letter Grade = {result.Letter}");

          //Assert
          Assert.Equal(85.7, result.Average, 1);
          Assert.Equal(90.5, result.High, 1);
          Assert.Equal(77.5, result.Low, 1);
          Assert.Equal('B', result.Letter);
        }
    }
}
