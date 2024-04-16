

namespace uge_15_opgaver
{
    public class Controller
    {
        public List<Book> Books { get; set; }
        public List<Amulet> Amulets { get; set; }
        public List<Course> Courses { get; set; }
        //private BookRepository bookRepo;
        //private AmuletRepository amuletRepo;
        private CourseRepository courseRepo;
        private MerchandiseRepository merchandiseRepo;

        public Controller() {
            //bookRepo = new BookRepository();
            //amuletRepo = new AmuletRepository();
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            Courses = new List<Course>();
            courseRepo = new CourseRepository();
            merchandiseRepo = new MerchandiseRepository();
        }

        public void AddToList(Book book) 
        { 
            merchandiseRepo.AddMerchandise(book);
            Books.Add(book);
        }
        public void AddToList(Amulet amulet)
        {
            merchandiseRepo.AddMerchandise(amulet);
            Amulets.Add(amulet);
        }
        public void AddToList(Course course)
        {
            courseRepo.AddCourse(course);
            Courses.Add(course);
        }

       


    }
}
