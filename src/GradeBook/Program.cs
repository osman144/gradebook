using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          double[] numbers = new[] {5, 1.1, 2.5, 3.7, 9.33};
          List<double> grades = new List<double>() {5, 1.1, 2.5, 3.7, 9.33};
          grades.Add(56.1);

          var result = 0.0;


          foreach (var number in grades)
          {
              result = result + number;
          }

          var average = (result) / grades.Count;

          Console.WriteLine($"{result:N1}");
          Console.WriteLine($"{average:N3}");
        }
    }
}
