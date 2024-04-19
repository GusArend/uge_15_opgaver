

namespace uge_15_opgaver
{
    public class Controller
    {
        public ValuableRepository ValuableRepo { get; set; }

        public Controller() {
            ValuableRepo = new ValuableRepository();
           
        }

        public void AddToList(IValuable valuable) 
        { 
          ValuableRepo.AddValuable(valuable);
        }
        

       


    }
}
