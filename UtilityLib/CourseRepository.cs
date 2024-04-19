
//namespace uge_15_opgaver
//{
//    public class CourseRepository
//    {
//        private List<Course> courses = new List<Course>();
       

//        public void AddCourse(Course course)
//        {
//            courses.Add(course);
//        }

//        public Course GetCourse(string name)
//        {
//            Course course = courses.FirstOrDefault(x => x.Name == name);
//            return course;
//        }

//        public double GetTotalValue()
//        {
//            Utility utility = new Utility();
//            double price = 0;
//            foreach (Course course in courses)
//            {

//                //double timeInHours = course.DurationInMinutes / 60;
//                //price += 875 * Math.Ceiling(timeInHours);
//                price += utility.GetValueOfCourse(course);
//            }
//            return price;

//        }
//    }
//}
