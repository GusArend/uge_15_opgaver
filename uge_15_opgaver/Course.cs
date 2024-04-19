

using System.Diagnostics;

namespace uge_15_opgaver
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public double value = 0;
       
        public static double CourseHourValue = 875.0;

        public Course(string name)
        { 
            Name = name;
        }

        public double GetValue()
        {
            int timeInHours = DurationInMinutes / 60;
            double remainder = DurationInMinutes % 60;
            double price = 0;
            if (remainder > 0)
            {
                price = CourseHourValue * (timeInHours + 1);
            }
            else
            {
                price = CourseHourValue * timeInHours;
            }
            
            return price;
        }

        public Course(string name, int duration) : this(name)
        {
            DurationInMinutes = duration;
        }


        public override string ToString()
        {
            value = GetValue();
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {value}";
        }
    }
}
