using System.Collections.Generic;
using System.Threading.Tasks;
using Eight.Data.Interfaces;
using Eight.Domian.Models;

namespace Eight.Data.Repositories
{
    public class DailyEntryData : IDailyEntryData
    {
        public ISqlDataAccess _repository { get; }

        public DailyEntryData(ISqlDataAccess repository)
        {
            _repository = repository;
        }

        public Task<List<DayEntry>> GetAllDailyEntries()
        {
            var sql = "Select * From dbo.DayEntry";

            return _repository.LoadData<DayEntry, dynamic>(sql, new { });
        }

        public Task InsertDayEntry(DayEntry newEntry)
        {
            string sql = @"Insert into dbo.DayEntry 
                           (Description, DateLogged, DayRating, ActivitiesCompleted, CategoryId)
                           values 
                           (@Description, @DateLogged, @DayRating, @ActivitiesCompleted, @CategoryId);";

            return _repository.SaveData(sql, newEntry);
        }
    }
}
