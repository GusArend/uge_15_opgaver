//namespace uge_15_opgaver
//{
//    public class MerchandiseRepository: Merchandise
//    {
//        private List<Merchandise> merchandises = new List<Merchandise>();

//        public void AddMerchandise(Merchandise merchandise)
//        {
//            merchandises.Add(merchandise);
//        }

//        public Merchandise GetMerchandise(string itemId) {
//            return merchandises.Find(m => m.ItemId == itemId);
//        }

//        public double GetTotalValue()
//        {
//            Utility utility = new Utility();
//            double price = 0;
//            foreach (Merchandise merchandise in merchandises)
//            {
//                price += utility.GetValueOfMerchandise(merchandise);
                
//            }
//            return price;
            
//        }
//        public double GetTotalValue(string type)
//        {

//            Utility utility = new Utility();
//            double price = 0;
//            foreach (Merchandise merchandise in merchandises)
//            {
                
//                    if (type == "books" && merchandise is Book book)
//                    {
//                        price += utility.GetValueOfMerchandise(book);
//                    } else if (type == "amulets" && merchandise is Amulet amulet)
//                {
//                    price += utility.GetValueOfMerchandise(amulet);
//                }
                   
                
                

//            }
//            return price;

//        }
       

//    }
//}
