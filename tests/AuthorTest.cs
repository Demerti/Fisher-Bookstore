using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace tests
{
    public class AuthorTest
    {
        [Fact]
        public void ChangeAuthorName()
        {
            //Arrange
            
                var Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                };

            //Act
            var newPenname = "The Big E";
            Author.ChangeAuthorName(newPenname);
            

            //Assert
            var NewPen = newPenname;
            var CurrentAuthorName = Author.Name;

            AssemblyLoadEventArgs.Equals(NewPen, CurrentAuthorName);
        }
    }
}