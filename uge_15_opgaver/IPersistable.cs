

namespace uge_15_opgaver
{
    public interface IPersistable
    {
        void Save();
        void Save(string filename);

        void Load();
        void Load(string filename);
    }
}
