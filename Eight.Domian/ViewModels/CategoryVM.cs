using System.ComponentModel.DataAnnotations;
using Eight.Domian.Models;

namespace Eight.Domian.ViewModels
{
    public class CategoryVM
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public bool IsProductive { get; set; }

        [Required]
        public ClassificationEnum Classification { get; set; }
    }
}
