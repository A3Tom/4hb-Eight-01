using System.ComponentModel.DataAnnotations;

namespace Eight.Domian.ViewModels
{
    public class DayEntryVM
    {
        [Required]
        public string Description { get; set; }

        [Required(ErrorMessage = "Look mate, you have to give it some rating you fuckin dobber.")]
        [Range(0.0, 10.0, ErrorMessage = "Naw, naw, naw. You know the score. 0.0 to 10.0 n fuck all outside of that")]
        public decimal DayRating { get; set; }
        [Range(0, 255, ErrorMessage = "Fuck right off if you are trying to sit there n chant that you have managed to do more than 255 things. No chance mate")]
        public int ActivitiesCompleted { get; set; }

        [Required]
        public int CategoryId { get; set; }

    }
}
