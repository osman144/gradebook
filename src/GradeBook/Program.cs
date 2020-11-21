using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          var book = new Book("Sal's Grade Book");
          book.AddGrade(56.1);
          book.AddGrade(90.1);
          book.AddGrade(90.0);
          book.AddGrade(85.0);
          book.AddGrade(75.5);
          // book.ShowStats();
          
        }
    }
}
