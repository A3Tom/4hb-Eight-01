using System.Collections.Generic;
using System.Threading.Tasks;
using Eight.Domian.Models;

namespace Eight.Data.Repositories
{
    public interface ICategoryData
    {
        Task<List<Category>> GetAllCategories();
        Task InsertCategory(Category newCategory);
    }
}
