
namespace uge_15_opgaver
{
    public class Utility
    {
        public double LowQualityValue = 12.5;
        public double MediumQualityValue = 20.0;
        public double HighQualityValue = 27.5;
        public double CourseHourValue = 875.0;



        public double GetValueOfMerchandise(Merchandise item)
        {
          
            if (item == null)
            {
                throw new Exception("Merchandise not found");
            }

            if (item is Book book)
            {
                return book.Price;
            }
            else if (item is Amulet amulet)
            {
                double price = 0;
                switch (amulet.Quality)
                {
                    case Level.high:
                        price = HighQualityValue;
                        break;
                    case Level.medium:
                        price = MediumQualityValue;
                        break;
                    case Level.low:
                        price = LowQualityValue;
                        break;
                    default:
                        throw new InvalidOperationException("Unknown amulet quality");
                }
                return price;
            }
            else
            {
                throw new InvalidOperationException("Unknown merchandise type");
            }
        }

        //public double GetValueOfBook(Book book)
        //{
        //    return book.Price;
        //}

        //public double GetValueOfAmulet(Amulet amulet)
        //{
        //    double price = 0;
        //    switch (amulet.Quality)
        //    {
        //        case Level.high:
        //            price = HighQualityValue;
        //            break;
        //        case Level.medium:
        //            price = MediumQualityValue;
        //            break;
        //        case Level.low:
        //            price = LowQualityValue;
        //            break;

        //    }
        //    return price;

        //}

        public double GetValueOfCourse(Course course)
        {
            int timeInHours = course.DurationInMinutes / 60;
            double remainder = course.DurationInMinutes % 60;

            if (remainder > 0)
            {
                return CourseHourValue * (timeInHours + 1);
            }
            else
            {
                return CourseHourValue * timeInHours;
            }

            // double timeInHours = course.DurationInMinutes / 60;
            // return 875 * Math.Ceiling(timeInHours)
        }
    }
}
