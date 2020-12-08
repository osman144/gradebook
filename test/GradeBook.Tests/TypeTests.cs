using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

      [ Fact]
      public void GetBookReturnsDifferentObjects()
      {
        var book1 = GetBook("Book1");
        var book2 = GetBook("Book2");

        Assert.Equal("Book1", book1.Name);
        Assert.Equal("Book2", book2.Name);
        Assert.NotSame(book1, book2);
      }

      [Fact]
      public void TwoVarsCanReferenceSameObject()
      {
        var book1 = GetBook("Book1");
        var book2 = book1;

        Assert.Equal("Book1", book1.Name);
        Assert.Equal("Book1", book2.Name);
        Assert.Same(book1, book2);
      }
      
      Book GetBook(string name)
      {
        return new Book(name);
      }
  }
}
