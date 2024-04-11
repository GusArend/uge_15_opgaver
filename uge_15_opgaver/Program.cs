namespace uge_15_opgaver
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            Utility utility = new Utility();

            new Amulet("12", Level.medium, "Ring", controller);
            new Amulet("13", Level.high, "Necklace", controller);

            new Book("23", "SomeBook", 12.95, controller);



            Book book1 = new Book("3", "SomeOtherBook", 102.95);
            controller.AddToList(book1);


            Console.WriteLine("Books:");
            foreach (Book b in controller.Books)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Amulets:");
            foreach (Amulet a in controller.Amulets)
            {
                Console.WriteLine(a + ", Price: " + utility.GetValueOfAmulet(a));
            }
            Console.ReadLine();
        }
    }
}
