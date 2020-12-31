using System.Threading.Tasks;
using Eight.Data.Interfaces;
using Eight.Domian.Models;

namespace Eight.Data.Repositories
{
    public class CategoryData
    {
        public ISqlDataAccess _repository { get; }

        public CategoryData(ISqlDataAccess repository)
        {
            _repository = repository;
        }

        public Task GetAllCategories()
        {
            var sql = "Select * From dbo.Category";

            return _repository.LoadData<DayEntry, dynamic>(sql, new { });
        }
        public Task InsertCategory(Category newCategory)
        {
            string sql = @"Insert into dbo.Category 
                           (Name, IsProductive, Classification)
                           values 
                           (@Name, @IsProductive, @Classification);";

            return _repository.SaveData(sql, newCategory);
        }

    }
}
