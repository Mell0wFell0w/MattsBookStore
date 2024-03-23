
using MattsBookStore.Models;
using SQLitePCL;
using static System.Reflection.Metadata.BlobBuilder;

namespace MattsBookStore.Models
{
    public class EFBookRepository : IBookRepository
    {
        private MattsBooksContext _context;
        public EFBookRepository(MattsBooksContext temp)
        {
            _context = temp;
        }
        public IQueryable<Books> Books => _context.Books;
    }
}