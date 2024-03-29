﻿namespace FormiWebshop.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        event Action OnChange;
        List<Category> Categories { get; set; }
        List<Category> AdminCategories { get; set; }
        Task GetCategories();
        Task GetAdminCategories();
        Task AddCategory(Category category);
        Task UpdateCategories(Category category);
        Task DeleteCategories(int categoryId);
        Category CreateNewCategory();
    }
}
