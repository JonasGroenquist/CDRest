using CDRest.Model;
using static System.Reflection.Metadata.BlobBuilder;

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

        public List <Record> GetAll(string? title = null, string? artist = null, string? sortBy = null)
        {
            List<Record> records = new(Data);

            if (title != null)
            {
                records = records.FindAll(record => record.Title.StartsWith(title));
            }
            if (artist != null)
            {
                records = records.FindAll(record => record.Artist.StartsWith(artist));
            }
            if (sortBy != null)
            {
                switch (sortBy.ToLower())
                {
                    case "id":
                        records = records.OrderBy(record => record.Id).ToList();
                        break;
                    case "title":
                        records = records.OrderBy(record => record.Title).ToList();
                        break;
                    case "artist":
                        records = records.OrderBy(record => record.Artist).ToList();
                        break;
                    case "year":
                        records = records.OrderBy(record => record.Year).ToList();
                        break;
                }
            }
            return records;
        }
    }
}
