

namespace uge_15_opgaver
{
    public class Merchandise
    {
        public string ItemId { get; set; }

        public Merchandise(string itemId)
        {
            ItemId = itemId;
        }

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    }
}
