using System;

namespace Adapter.Book
{
    public class XMLBook: IBook
    {
        public string Id { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id} \nAuthor name: {this.AuthorName} \nTitle: {this.Title} \nPrice: {this.Price} \nPublish date: {this.PublishDate} \nDescription: {this.Description}";
        }
}
}
