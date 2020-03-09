namespace Adapter.Book
{
    public interface IBook
    {
        public string Id { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public System.DateTime PublishDate { get; set; }
        public string Description { get; set; }
    }
}
