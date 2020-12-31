namespace Eight.Domian.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsProductive { get; set; }
        public ClassificationEnum Classification { get; set; }
    }
}
