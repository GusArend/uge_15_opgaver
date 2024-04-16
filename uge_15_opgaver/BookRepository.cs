

namespace uge_15_opgaver
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            Book book = books.FirstOrDefault(x => x.ItemId == itemId);
            return book;
        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double total = 0;
            foreach (Book book in books)
            {
                //total += book.Price;

                //total += utility.GetValueOfBook(book);
            }
            return total;
        }
    }
}
