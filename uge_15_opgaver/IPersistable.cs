

namespace uge_15_opgaver
{
    public interface IPersistable
    {
        
        void Save(string? filename);
        void Load(string? filename);
    }
}
