using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mrsProject.DAL;
using mrsProject.Models;

namespace mrsProject.Controllers
{
    public enum SortOptions { Title, Author, NumberPurchased, New, Old, Rated}
   
    public class SearchController : Controller

    {
        private AppDbContext _db;
        public IActionResult Index()
        {
            return View();
        }

       

        public ActionResult Search()
        {
            ViewBag.AllBooks = GetAllBooks();
            return View("SearchResults");
        }



        public ActionResult DisplaySearchResults(string SearchGenre, string SearchTitle, string SearchAuthor, SortOptions sort)
        {
            ViewBag.BookCount = "The total number of books is" + _db.Books.Count();
            List<Book> SelectedBooks = new List<Book>();
            

            var query = from r in _db.Books
                        select r;
            if (SearchGenre != null && SearchGenre != "")
            {
                query = query.Where(r => r.Genre.GenreName.Contains(SearchGenre));
            }
            if (SearchTitle != null && SearchTitle != "")
            {
                query = query.Where(r => r.Title.Contains(SearchTitle));
            }
            if (SearchAuthor != null && SearchAuthor != "")
            {
                query = query.Where(r => r.Author.Contains(SearchAuthor));
            }

            SelectedBooks = query.Include(r => r.Genre).ToList();
            ViewBag.TotalBooks = _db.Books.Count();
            ViewBag.SelectedBooks = SelectedBooks.Count();


            


            switch (sort)
            {
                case SortOptions.Title:
                    return View("SearchResults", SelectedBooks.OrderBy(r => r.Title));
                case SortOptions.Author:
                    return View("SearchResults", SelectedBooks.OrderBy(r => r.Author));
                case SortOptions.New:
                    return View("SearchResults", SelectedBooks.OrderBy(r => r.PublicationDate));
                case SortOptions.Old:
                    return View("SearchResults", SelectedBooks.OrderByDescending(r => r.PublicationDate));
                case SortOptions.NumberPurchased:
                    return View("SearchResults", SelectedBooks.OrderBy(r => r.NumPurchased));
                case SortOptions.Rated:
                    return View("SearchResults", SelectedBooks.OrderBy(r => r.SimpleRating));
            }
            

            return View();


        }

        public IActionResult BookDetails(int? id)
        {
            if (id == null) //Repo id not specified
            {
                return View("Error", new String[] { "Book ID not specified - which book do you want to view?" });
            }

            Book b = _db.Books.Include(r => r.Genre).FirstOrDefault(r => r.BookID == id);

            if (b == null) //Repo does not exist in database
            {
                return View("Error", new String[] { "Book not found in database" });
            }

            //if code gets this far, all is well
            return View(b);
        }

       
        public SearchController(AppDbContext context)
        {
            _db = context;
        }

        public SelectList GetAllBooks()
        {
            List<Book> Books = _db.Books.ToList();

            Book SelectNoBook = new Book() { BookID = 0, Title = "All Books" };

            Books.Add(SelectNoBook);

            SelectList AllBooks = new SelectList(Books.OrderBy(B => B.BookID), "BookID", "Title");

            return AllBooks;
        }

        public ActionResult AllBooks(string SearchString)
        {
            ViewBag.BookCount = "The total number of Books is " + _db.Books.Count();
            List<Book> SelectedBooks = new List<Book>();

            

            var query = from r in _db.Books
                        select r;

            SelectedBooks = query.Include(r => r.Genre).ToList();

            ViewBag.TotalBooks = _db.Books.Count();
            ViewBag.SelectedBooks = SelectedBooks.Count();
            return View("SearchResults", SelectedBooks);

        }
    }
}