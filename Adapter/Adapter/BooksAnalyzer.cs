using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Adapter
{
    public class BooksAnalyzer
    {
        public Book GetOldestBook()
        {
            List<Book> bookList = new List<Book>();
            string jsonString = File.ReadAllText("Books.json");
            dynamic files = JsonConvert.DeserializeObject(jsonString);

            foreach (var f in files.objects)
               bookList.Add(new Book(f.id, f.authorName, f.title, (double)f.price, (DateTime)f.publishDate, f.description));
            return FindOldestBook(bookList);
        }

        private Book FindOldestBook(List<Book> bookList)
        {
            DateTime minPublishDate = DateTime.Today;
            Book oldestBook = new Book();
            foreach (Book book in bookList)
            {
                if (book.PublishDate < minPublishDate)
                {
                    minPublishDate = book.PublishDate;
                    oldestBook = book;
                }
            }
            return oldestBook;
        }
    }
}