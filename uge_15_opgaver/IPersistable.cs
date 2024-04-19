

namespace uge_15_opgaver
{
    public interface IPersistable
    {
        
        void Save(string? filename = "ValuableRepository.txt");

        
        void Load(string? filename = "ValuableRepository.txt");
    }
}
