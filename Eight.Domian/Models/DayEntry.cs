using System;

namespace Eight.Domian.Models
{
    public class DayEntry
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateLogged { get; set; }
        public decimal DayRating { get; set; }
        public byte ActivitiesCompleted { get; set; }
        public int CategoryId { get; set; }
        
        public virtual Category Category { get; set; }
    }
}
