using System.Collections.Generic;
using System.Threading.Tasks;
using Eight.Data.Interfaces;
using Eight.Domian.Models;

namespace Eight.Data.Repositories
{
    public class IDailyEntryData
    {
        public ISqlDataAccess _repository { get; }

        public IDailyEntryData(ISqlDataAccess repository)
        {
            _repository = repository;
        }

        public Task<List<DayEntry>> GetAllDayEntries()
        {
            var sql = "Select * From dbo.DayEntry";

            return _repository.LoadData<DayEntry, dynamic>(sql, new { });
        }

        public Task InsertDayEntry(DayEntry person)
        {
            string sql = @"Insert into dbo.DayEntry 
                           (Description, DateLogged, DayRating, ActivitiesCompleted)
                           values 
                           (@Description, @DateLogged, @DayRating, @ActivitiesCompleted);";

            return _repository.SaveData(sql, person);
        }
    }
}
