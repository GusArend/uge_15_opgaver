

namespace uge_15_opgaver
{
    public class Course
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public Course(string name)
        { 
            Name = name;
        }

        public Course(string name, int duration) : this(name)
        {
            DurationInMinutes = duration;
        }


        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }
    }
}
