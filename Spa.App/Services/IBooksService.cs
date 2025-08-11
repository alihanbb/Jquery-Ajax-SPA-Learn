using Spa.App.ViewModel;

namespace Spa.App.Services
{
    public interface IBooksService
    {
        Task AddBooksAsync(CreateBookViewModel createBookViewModel);
        Task<bool> DeleteBookAsync(int id);
        Task<List<ResultBookViewModel>> GetAllBooksAsync();
        Task<ResultBookViewModel> GetBookByIdAsync(int id);
        Task<bool> UpdateBookAsync(UpdateBookViewModel updateBookViewModel);
    }
}
