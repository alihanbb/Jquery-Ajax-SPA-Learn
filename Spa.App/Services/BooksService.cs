using Microsoft.EntityFrameworkCore;
using Spa.App.Models;
using Spa.App.ViewModel;

namespace Spa.App.Services
{
    public class BooksService : IBooksService
    {
        private readonly Context _context;
        public BooksService(Context context)
        {
            _context = context;
        }
        public async Task AddBooksAsync(CreateBookViewModel createBookViewModel)
        {
            var addBook = new Books
            {
                Name = createBookViewModel.Name,
                Author = createBookViewModel.Author,
                ISBN = createBookViewModel.ISBN,
                Description = createBookViewModel.Description,
                Genre = createBookViewModel.Genre
            };
            _context.Books.Add(addBook);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            { 
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<ResultBookViewModel>> GetAllBooksAsync()
        {
            var books = await _context.Books.ToListAsync();

            return books.Select(book => new ResultBookViewModel(book.Id, book.Name, book.Author, book.ISBN, book.Description)).ToList();
        }
        
        public async Task<ResultBookViewModel> GetBookByIdAsync(int id)
        {
          var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return null;
            }
            return new ResultBookViewModel(book.Id, book.Name, book.Author, book.ISBN, book.Description);
        }
        public async Task<bool> UpdateBookAsync(UpdateBookViewModel updateBookViewModel)
        {
            var book = await _context.Books.FindAsync(updateBookViewModel.Id);
            if (book != null)
            {
                book.Name = updateBookViewModel.Name;
                book.Author = updateBookViewModel.Author;
                book.ISBN = updateBookViewModel.ISBN;
                book.Description = updateBookViewModel.Description;
                book.Genre = updateBookViewModel.Genre;
                _context.Books.Update(book);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
