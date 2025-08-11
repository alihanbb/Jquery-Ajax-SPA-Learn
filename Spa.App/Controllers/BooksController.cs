using Microsoft.AspNetCore.Mvc;
using Spa.App.Services;
using Spa.App.ViewModel;

namespace Spa.App.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;
        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetAllBooks()
        {
            var books = await _booksService.GetAllBooksAsync();
            return Json(books);
        }

        [HttpGet]
        public async Task<JsonResult> UpdateBook(int id)
        {
            var book = await _booksService.GetBookByIdAsync(id);
            if (book == null)
            {
                return Json(new { success = false, message = "İlgili Kitap bilgisi bulunamadı" });
            }
            return Json(book);
        }


        [HttpPost]
        public async Task<JsonResult> UpdateBook([FromBody] UpdateBookViewModel updateBookViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _booksService.UpdateBookAsync(updateBookViewModel);
                if (result)
                {
                    return Json(new { success = true, message = "Kitap bilgisi başarıyla güncellendi" });
                }
                return Json(new { success = false, message = "İlgili kitap bulunamadı" });
            }
            
            return Json(new { success = false, message = "Geçersiz bilgi girişi" });
        }
        [HttpGet]
        public async Task<JsonResult> DeleteBook(int id)
        {
            var result = await _booksService.DeleteBookAsync(id);
            if (result)
            {
                return Json(new { success = true, message = "Kitap başarıyla silindi" });
            }
            return Json(new { success = false, message = "İlgili kitap bulunamadı" });
        }


        [HttpPost]
        public async Task<JsonResult> AddBook([FromBody] CreateBookViewModel createBookViewModel)
        {
            if (ModelState.IsValid)
            {
                await _booksService.AddBooksAsync(createBookViewModel);
                return Json(new { success = true, message = "Kitap başarıyla eklendi" });
            }
            
     
            
            return Json(new { success = false, message = "Geçersiz bilgi girişi" });
        }

    }
}
