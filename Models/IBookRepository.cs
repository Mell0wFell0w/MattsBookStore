using static System.Reflection.Metadata.BlobBuilder;

namespace MattsBookStore.Models
{
    public interface IBookRepository
    {
        public IQueryable<Books> Books { get; }
    }
}