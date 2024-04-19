
namespace uge_15_opgaver
{
    public class Book: Merchandise
    {
       
        public string Title {  get; set; }
        public double Price { get; set; }

       
        public Book(string itemId)
        {
           ItemId = itemId;
            Title = string.Empty;
            Price = 0;

        }
        public Book(string itemId, string title)
        {
          ItemId= itemId;
            Title = title;
        }
        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public Book(string itemId, string title, double price, Controller controller)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
            controller.AddToList(this);
        }

        public override double GetValue() { return Price; }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
