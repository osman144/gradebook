﻿using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          var book = new Book("Sal's Grade Book");
          
          var done = false;

          while(!done){
            Console.WriteLine("Enter a grade or 'q' to quit");
            var input = Console.ReadLine();
            if(input == "q"){
              // done = true;
              // continue;
              break;
            }   

            try
            {
              var grade = double.Parse(input);
              book.AddGrade(grade);
            }
            catch(ArgumentException ex)
            {
              Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
              Console.WriteLine(ex.Message);
            }
            finally
            {
              Console.WriteLine("**");
            }
          }

          var stats = book.GetStats();


          Console.WriteLine(Book.Category);
          Console.WriteLine($"For the book named {book.Name}");
          Console.WriteLine($"The lowest grade is {stats.Low}");
          Console.WriteLine($"The highest grade is {stats.High}");
          Console.WriteLine($"The average grade is {stats.Average:N1}");
          Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
