//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace uge_15_opgaver
//{
//    public class AmuletRepository
//    {
//        private List<Amulet> amulets = new List<Amulet>();

//        public void AddAmulet(Amulet amulet)
//        {
//            amulets.Add(amulet);
//        }

//        public Amulet GetAmulet(string itemId)
//        {
//            Amulet amulet = amulets.FirstOrDefault(x => x.ItemId == itemId);
//            return amulet;
//        }

//        public double GetTotalValue()
//        {
//            Utility utility = new Utility();
//            double price = 0;
//            foreach (Amulet amulet in amulets)
//            {

//                //switch (amulet.Quality)
//                //{
//                //    case Level.high:
//                //        price = 27.5;
//                //        break;
//                //    case Level.medium:
//                //        price = 20.0;
//                //        break;
//                //    case Level.low:
//                //        price = 12.5;
//                //        break;

//                //}
//                //price += utility.GetValueOfAmulet(amulet);
//            }
//            return price;
           
//        }
//    }
//}