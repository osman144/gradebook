using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
          // Arrange
          var book = new Book("");
          book.AddGrade(89.1);
          book.AddGrade(90.5);
          book.AddGrade(77.5);


          // Act 
          var stats = book.GetStats();

          Console.WriteLine($"Max = {stats.High}");
          Console.WriteLine($"Min = {stats.Low}");
          Console.WriteLine($"Average = {stats.Average:N3}");

          //Assert
          Assert.Equal(85.7, stats.Average, 1);
          Assert.Equal(90.5, stats.High, 1);
          Assert.Equal(77.5, stats.Low, 1);
        }
    }
}
