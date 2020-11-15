using System;
using System.Collections.Generic;

namespace GradeBook{

  class Book {
    private List<double> grades;
    private string name;
    public Book(string name){
      grades = new List<double>() {};
      this.name = name;
    }
    public void AddGrade(double grade){
      grades.Add(grade);
    } 

    public void ShowStats(){
      var result = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      foreach (var number in grades)
      {
          lowGrade = Math.Min(number, lowGrade);
          highGrade = Math.Max(number, highGrade);
          result = result + number;
      }

      var average = (result) / grades.Count;

      Console.WriteLine($"Max = {highGrade}");
      Console.WriteLine($"Min = {lowGrade}");
      Console.WriteLine($"Average = {average:N3}");
    }
  }
}