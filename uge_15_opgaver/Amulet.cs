
namespace uge_15_opgaver
{
    public class Amulet: Merchandise
    {
        public static double LowQualityValue = 12.5;
        public static double MediumQualityValue = 20.0;
        public static double HighQualityValue = 27.5;
        public static double CourseHourValue = 875.0;
        public string Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string itemId)
        {
           ItemId = itemId;  
        }
        public Amulet(string itemId, Level quality)
        {
            ItemId= itemId;
            Quality = quality;

        }
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;

        }
      
        public override double GetValue()
        {
            double price = 0;
            switch (Quality)
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


        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }


    }
}
