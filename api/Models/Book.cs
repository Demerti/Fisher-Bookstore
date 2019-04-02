using System;

namespace Fisher.Bookstore.Models
{
    public class Book
    {
        public int Id { get; set;}

        public string Title { get; set;}

        public Author Author { get; set;}

        public String ISBN { get; set;}

        public DateTime PublishDate { get; set;}

        public string Publisher {get; set;}

        public void ChangePublicationDate(DateTime dateTime)
        {
            this.PublishDate = dateTime;
        }

        public void ChangePublisher(string Stellar)
        {
            this.Publisher= Publisher;
        }

    
    }
}