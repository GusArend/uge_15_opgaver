

namespace uge_15_opgaver
{
    public class Utility
    {
        public double GetValueOfBook(Book book) {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            double price = 0;
            switch (amulet.Quality)
            {
                case Level.high:
                    price= 27.5;
                    break;
                case Level.medium:
                    price= 20.0;
                    break;
                case Level.low:
                    price= 12.5;
                    break;

            }
                return price;
            
        }
    }
}
