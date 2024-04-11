using uge_15_opgaver;

namespace UtilityLib
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
                    price = 27.5;
                    break;
                case Level.medium:
                    price = 20.0;
                    break;
                case Level.low:
                    price = 12.5;
                    break;

            }
                return price;
            
        }

        public double GetValueOfCourse(Course course)
        {
            int timeInHours = course.DurationInMinutes / 60;
            double remainder = course.DurationInMinutes % 60;

            if (remainder > 0)
            {
                return 875 * (timeInHours + 1);
            } else
            {
                return 875 * timeInHours;
            }

            // double timeInHours = course.DurationInMinutes / 60;
            // return 875 * Math.Ceiling(timeInHours)
        }
    }
}
