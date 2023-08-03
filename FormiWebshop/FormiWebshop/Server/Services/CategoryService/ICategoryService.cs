namespace FormiWebshop.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
