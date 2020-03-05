using System;

namespace Adapter
{
    public class Book
    {
        public string Id;
        public string AuthorName;
        public string Title;
        public double Price;
        public DateTime PublishDate;
        public string Description;

        public Book()
        {

        }

        public Book(string id, string authorName, string title, double price, DateTime publishDate, string description)
        {
            Id = id;
            AuthorName = authorName;
            Title = title;
            Price = price;
            PublishDate = publishDate;
            Description = description;
        }

        public override string ToString()
        {
            return "ID: " + Id + "\nAuthor name: " + AuthorName + "\nTitle: " + Title + "\nPrice: " + Price +
                       "\nPublish date: " + PublishDate + "\nDescription: \n" + Description;
        }
    }
}
