

namespace uge_15_opgaver
{
    public abstract class Merchandise : IValuable
    {
        public string ItemId { get; set; }

        public abstract double GetValue();
       

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    }
}
