using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment.Models;
namespace MVC_Assignment.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BookInfo()
        {
            Book book = new Book()
            {
                BookId = 1,
                BookName = "Teach Yourself C",
                BookAuthor = "Herbert Schild"
            };

            ViewBag.book = book;
            ViewData["book1"] = book;

            return View(book);
        }

        public ActionResult BookList()
        {
            Book book = new Book()
            {
                BookId = 1,
                BookName = "Teach Yourself C",
                BookAuthor = "Herbert Schild"
            };

            List<Book> books = new List<Book>() {

            new Book()
            {
                BookId = 1,
                BookName = "Teach Yourself C",
                BookAuthor = "Herbert Schild"
            },
            new Book()
            {
                BookId = 2,
                BookName = "Data Com",
                BookAuthor = "Shane Warne"
            },
            new Book()
            {
                BookId = 3,
                BookName = "Misir Ali",
                BookAuthor = "Humayun Ahmed"
            },

        };

            return View(books);
        }
    }
} 