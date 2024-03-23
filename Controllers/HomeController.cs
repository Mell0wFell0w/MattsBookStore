using MattsBookStore.Models;
using MattsBookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MattsBookStore.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index(int PageNum = 1)
        {
            int PageSize = 10;
            var Blah = new BooksListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((PageNum - 1) * PageSize)
                .Take(PageSize),
                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = PageNum,
                    ItemsPerPage = PageSize,
                    TotalItems = _repo.Books.Count()
                }

            };

            return View(Blah);
        }


    }
}