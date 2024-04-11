

namespace uge_15_opgaver
{
    public abstract class Merchandise
    {
        public string ItemId { get; set; }

      

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    }
}
