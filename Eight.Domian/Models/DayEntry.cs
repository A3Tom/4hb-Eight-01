using System;

namespace Eight.Domian.Models
{
    public class DayEntry
    {
        public string Description { get; init; }
        public DateTime DateLogged { get; init; }
        public decimal DayRating { get; init; }
        public byte ActivitiesCompleted { get; init; }
    }
}
