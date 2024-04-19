

using System.Diagnostics;

namespace uge_15_opgaver
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables {  get; set; } 

        public ValuableRepository()
        {
            valuables = new List<IValuable>();
        }

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string id) 
        {
            foreach (var valuable in valuables)
            {
                if (valuable is Merchandise merchandise && merchandise.ItemId == id)
                {
                    return valuable;
                }
                else if (valuable is Course course && course.Name == id)
                {
                    return valuable;
                }
            }

            // If no valuable with the provided ID is found
            return null;

        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (var val in valuables)
            {
                if (val is Book book)
                {
                    total += book.GetValue();
                } else if (val is Amulet amulet)
                {
                    total += amulet.GetValue();
                } else if (val is Course course)
                {
                    total += course.GetValue();
                }
            }
            return total;
        }

        public int Count()
        {
            return valuables.Count;
        }

        public void Save()
        {
            List<string> lines = new List<string>();
            foreach (var valuable in valuables)
            {
               
               if (valuable is Book book)
               {
                    lines.Add($"BOG;{book.ItemId};{book.Title};{book.GetValue()}");
               } else if (valuable is Amulet amulet)
               {
                    lines.Add($"AMULET;{amulet.ItemId};{amulet.Design};{amulet.GetValue()}");
               } else if (valuable is Course course)
                {
                    lines.Add($"COURSE;{course.Name};{course.DurationInMinutes};{course.GetValue()}");
                }
               
            }
            File.AppendAllLines("ValuableRepository.txt", lines);
        }

        public void Save (string filename)
        {
            List<string> lines = new List<string>();
            foreach (var valuable in valuables)
            {

                if (valuable is Book book)
                {
                    lines.Add($"BOG;{book.ItemId};{book.Title};{book.GetValue()}");
                }
                else if (valuable is Amulet amulet)
                {
                    lines.Add($"AMULET;{amulet.ItemId};{amulet.Quality};{amulet.GetValue()}");
                }
                else if (valuable is Course course)
                {
                    lines.Add($"COURSE;{course.Name};{course.DurationInMinutes};{course.GetValue()}");
                }

            }
            File.AppendAllLines(filename, lines);




        }
        public void Load()
        {
            string[] lines = File.ReadAllLines("ValuableRepository.txt");
            foreach (var line in lines)
            {
                string[] splitLine = line.Split(';');
                if (splitLine[0] == "BOG")
                {
                    Book book = new Book(splitLine[1], splitLine[2], double.Parse(splitLine[3]));
                    valuables.Add(book);
                } else if (splitLine[0] == "AMULET")
                {
                    Level level;
                    switch (splitLine[2])
                    {
                        case "low":
                            level = Level.low;
                            break;
                        case "medium":
                            level = Level.medium;
                            break;
                        default: level = Level.high; break;
                    }
                    Amulet amulet = new Amulet(splitLine[1], level, splitLine[3]);
                    valuables.Add(amulet);
                } else if (splitLine[0] == "COURSE")
                {
                    Course course = new Course(splitLine[1], int.Parse(splitLine[2]));
                    valuables.Add(course);
                }
            }
        }

        public void Load(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] splitLine = line.Split(';');
                if (splitLine[0] == "BOG")
                {
                    Book book = new Book(splitLine[1], splitLine[2], double.Parse(splitLine[3]));
                    valuables.Add(book);
                }
                else if (splitLine[0] == "AMULET")
                {
                    Level level;
                    switch (splitLine[2])
                    {
                        case "low":
                            level = Level.low;
                            break;
                        case "medium":
                            level = Level.medium;
                            break;
                        default: level = Level.high; break;
                    }
                    Amulet amulet = new Amulet(splitLine[1], level, splitLine[3]);
                    valuables.Add(amulet);
                }
                else if (splitLine[0] == "COURSE")
                {
                    Course course = new Course(splitLine[1], int.Parse(splitLine[2]));
                    valuables.Add(course);
                }
            }
        }
    }
}
