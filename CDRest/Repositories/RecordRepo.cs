using CDRest.Model;

namespace CDRest.Repositories
{
    public class RecordRepo
    {
        private static int _nextId = 1;
        private static readonly List<Record> Data = new()
        {
            new Record {Id = _nextId++, Title = "sang1", Artist = "Artist1", Year = 2008, Duration = 212},
            new Record {Id = _nextId++, Title = "sang2", Artist = "Artist2", Year = 2012, Duration = 223}
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List <Record> GetAll()
        {
            List<Record> records = new(Data);
            return records;
        }
    }
}
