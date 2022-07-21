using PhoneApp.Shared;

namespace PhoneApp.Server.Services.ProductService.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}