using System.Collections.Generic;
using System.Threading.Tasks;
using Eight.Domian.Models;

namespace Eight.Data.Repositories
{
    public interface IDailyEntryData
    {
        Task<List<DayEntry>> GetAllDailyEntries();
        Task InsertDayEntry(DayEntry newEntry);
    }
}
