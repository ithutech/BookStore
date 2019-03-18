using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBook.Models;

namespace WebBook.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        //Code them - Thay Anh
        public ActionResult Index()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Đạo tình", "Chu Ngọc", "/Images/daotinh.jpg"));
            books.Add(new Book(2, "Tây xuất ngọc môn", "Vĩ Ngư", "/Images/tayxuatngocmon.jpg"));
            books.Add(new Book(3, "Mười hai năm, kịch cố nhân", "Mặc Bảo Phi Bảo", "/Images/muoihainam.jpg"));
            books.Add(new Book(4, "Dụ tình", "Ân Tầm", "/Images/dutinh.jpg"));
            books.Add(new Book(5, "Khách sạn hoàng tuyền", "Cố Mạn", "/Images/khachsanhoangtuyen.jpg"));
            books.Add(new Book(6, "Không thể quay lại", "Diệp Lạc Vô Tâm", "/Images/time.png"));
            ViewBag.Books = books;
            return View(books);
        }
        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("HTML5 & CSS3 The complete Manual - Author Name Book 1");
            books.Add("HTML5 & CSS3 Responsive web Design cookbook - Author Name Book 2");
            books.Add("Professional ASP.NET MVC 5 - Author Name Book 2");
            ViewBag.Books = books;
            return View();
        }

        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Đạo tình", "Chu Ngọc", "/Images/daotinh.jpg"));
            books.Add(new Book(2, "Tây xuất ngọc môn", "Vĩ Ngư", "/Images/tayxuatngocmon.jpg"));
            books.Add(new Book(3, "Mười hai năm, kịch cố nhân", "Mặc Bảo Phi Bảo", "/Images/muoihainam.jpg"));
            ViewBag.Books = books;
            return View(books);
        }
    }
}