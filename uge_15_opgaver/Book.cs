
namespace uge_15_opgaver
{
    public class Book
    {
        public string ItemId { get; set; }
        public string Title {  get; set; }
        public double Price { get; set; }

        public Book()
        {
            ItemId = string.Empty;
            Title = string.Empty;
            Price = 0;
        }
        public Book(string itemId)
        {
            ItemId = itemId;
            Title = string.Empty;
            Price = 0;

        }
        public Book(string itemId, string title)
        {
            ItemId = itemId;
            Title = title;
        }
        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
