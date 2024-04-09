
namespace uge_15_opgaver
{
    public class Amulet
    {
        public string ItemId { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }

        //public Amulet()
        //{
        //    ItemId = string.Empty;
        //    Design = string.Empty;
        //    Quality = Level.medium;
        //}

        public Amulet(string itemId)
        {
            ItemId = itemId;
            
        }
        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId;
            Quality = quality;

        }
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;

        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }


    }
}
