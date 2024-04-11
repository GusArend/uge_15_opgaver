
namespace uge_15_opgaver
{
    public class Amulet: Merchandise
    {
        
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
        public Amulet(string itemId, Level quality, string design, Controller controller)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
            controller.AddToList(this);
        }


        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }


    }
}
