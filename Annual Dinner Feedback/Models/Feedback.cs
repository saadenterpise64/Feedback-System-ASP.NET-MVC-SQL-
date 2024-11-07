using System.ComponentModel.DataAnnotations;

namespace Annual_Dinner_Feedback.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; } // Primary key

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Contact number is required")]
        [StringLength(11, ErrorMessage = "Contact number should be 11 digits")]
        public string ContactNo { get; set; }

        [Display(Name = "Did you enjoy the dinner last night?")]
        public string Question1 { get; set; }

        [Display(Name = "Which dish did you like the most?")]
        public string Question2 { get; set; }

        [Display(Name = "What was your favourite dessert?")]
        public string Question3 { get; set; }

        [Display(Name = "Did you like the venue?")]
        public string Question4 { get; set; }

        [Display(Name = "Is there anything that concerned you?")]
        public string Question5 { get; set; }

        [Display(Name = "What could have been improved in the dinner?")]
        public string Question6 { get; set; }

        [Display(Name = "What additional items would you like next time?")]
        public string Question7 { get; set; }
    }
}
